using CsvHelper;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace XOptimization
{
    public partial class TranslationUC : UserControl
    {
        List<TitlePerformance> logs;
        Main main;
        public TranslationUC()
        {
            InitializeComponent();
            Init();
        }
        public TranslationUC(Main main)
        {
            InitializeComponent();
            this.main = main;
            Init();
        }

        private void Init()
        {
            cbbLanguage.Items.Clear();
            cbbLanguage.Items.Add("fr");
            cbbLanguage.Items.Add("de");
            cbbLanguage.Items.Add("it");
            cbbLanguage.Items.Add("es");
            cbbLanguage.Items.Add("vi");
            cbbLanguage.SelectedIndex = 4;
            try
            {
                TranslatorInfo setting = JsonConvert.DeserializeObject<TranslatorInfo>(File.ReadAllText(Helper.GetCurrentDirectory() + "\\Data\\translator.json"));
                txtTarget.Text = setting.Target;
                txtSource.Text = setting.Source;
                cbbLanguage.SelectedItem = setting.Language;
                txtReport.Text = setting.ReportDir;
            }
            catch (Exception)
            {
            }
            logs = new List<TitlePerformance>();
        }
        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog.SelectedPath;
                Environment.SpecialFolder root = folderBrowserDialog.RootFolder;
            }
        }

        private void btnChooseTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = folderBrowserDialog.SelectedPath;
                Environment.SpecialFolder root = folderBrowserDialog.RootFolder;
            }
        }
        private bool ValidateData()
        {
            if (!StringUtils.IsNotEmpty(txtSource.Text))
            {
                MessageBox.Show("Cần nhập đường dẫn nguồn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtTarget.Text))
            {
                MessageBox.Show("Cần nhập đường dẫn đích", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("Đường dẫn nguồn không tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Directory.Exists(txtTarget.Text))
            {
                MessageBox.Show("Đường dẫn đích không tồn tại", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty((string)cbbLanguage.SelectedItem))
            {
                MessageBox.Show("Cần nhập ngôn ngữ chuyển", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtReport.Text))
            {
                MessageBox.Show("Cần nhập đường dẫn lưu báo cáo", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Directory.Exists(txtReport.Text))
            {
                MessageBox.Show("Đường dẫn lưu báo cáo không tồn tại", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            SplashScreenManager.ShowForm(main, typeof(WaitingForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang xử lý...");
            Translate(txtSource.Text, txtTarget.Text, (string)cbbLanguage.SelectedItem);
            SplashScreenManager.CloseForm();
            MessageBox.Show("Ảnh đã được lưu vào trong thư mục:\n" + txtTarget.Text, "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Translate(string source, string dest, string language)
        {
            TitlePerformance performance = new TitlePerformance();
            string[] files = Directory.GetFiles(source);
            foreach (var file in files)
            {
                performance = new TitlePerformance();
                string ext = Path.GetExtension(file).ToUpper();
                if (ext == ".PNG" || ext == ".JPG" || ext == ".JPEG")
                {
                    try
                    {
                        var newPath = TranslateImageTitle(file, dest, language);
                        if (file.Equals(newPath))
                        {
                            performance.Note = "Lỗi dịch tiêu đề";
                        }
                        else
                        {
                            performance.Dest = newPath;
                            performance.DestName = new FileInfo(newPath).Name;
                        }
                    }
                    catch (Exception e)
                    {
                        performance.Note = "Lỗi dịch tiêu đề:" + e.Message;
                    }
                    performance.Source = file;
                    performance.SourceName = new FileInfo(file).Name;
                    logs.Add(performance);
                }
            }
            List<String> subDirs = Helper.GetSubDirectories(source);
            if (subDirs != null && subDirs.Count > 0)
            {
                foreach (String dir in subDirs)
                {
                    string extraDir = dir.Replace(source, "");
                    Translate(dir, dest + extraDir, language);
                }
            }
            if (!source.Equals(txtSource.Text))
            {
                performance = new TitlePerformance();
                var folderName = new DirectoryInfo(source).Name;
                var newPath = Command.RenameFolder(dest, TranslateText(folderName, language));
                if (source.Equals(newPath))
                {
                    performance.Note = "Lỗi dịch tiêu đề";
                }
                else
                {
                    performance.Dest = newPath;
                    performance.DestName = new FileInfo(newPath).Name;
                }
                performance.Source = source;
                performance.SourceName = new FileInfo(source).Name;
                logs.Add(performance);
            }
        }
        private string TranslateImageTitle(string filePath, string dest, string language)
        {
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }
            var fileName = Path.GetFileName(filePath);
            dest = dest + "\\" + TranslateText(fileName,language);
            Command.CopyFile(filePath, dest);
            return dest;
        }
        public string TranslateText(string input, string language)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", language, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (MessageBox.Show("Bạn có muốn lưu cấu hình này không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        TranslatorInfo compression = new TranslatorInfo();
                        compression.Source = txtSource.Text;
                        compression.Target = txtTarget.Text;
                        compression.Language = (string)cbbLanguage.SelectedItem;
                        compression.ReportDir = txtReport.Text;
                        Helper.WriteText(Helper.GetCurrentDirectory() + "\\Data\\translator.json", JsonConvert.SerializeObject(compression, Newtonsoft.Json.Formatting.Indented));
                        MessageBox.Show("Lưu cấu hình thành công", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể lưu thông tin. Liên hệ quản trị viên", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtReport.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = txtReport.Text + "\\Report" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(logs);
            }
            MessageBox.Show("Xuất báo cáo thành công. Báo cáo được lưu trong:\n" + filePath, "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            new Thread(() =>
                {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Command.OpenFile(filePath);
            }).Start();
        }
    }
}
