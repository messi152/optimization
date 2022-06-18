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
    public partial class TranslatorUC : UserControl
    {
        List<TitlePerformance> logs;
        Main main;
        ITranslator translator;
        public TranslatorUC()
        {
            InitializeComponent();
            Init();
        }
        public TranslatorUC(Main main)
        {
            InitializeComponent();
            this.main = main;
            Init();
        }

        private void Init()
        {
            cbbLanguage.Items.Clear();
            cbbLanguage.Items.Add("France-fr");
            cbbLanguage.Items.Add("Germany-de");
            cbbLanguage.Items.Add("Italy-it");
            cbbLanguage.Items.Add("Spain-es");
            cbbLanguage.Items.Add("Vietnam-vi");
            cbbLanguage.SelectedIndex = 4;
            try
            {
                TranslatorInfo setting = JsonConvert.DeserializeObject<TranslatorInfo>(File.ReadAllText(Helper.GetCurrentDirectory() + "\\Data\\translator.json"));
                txtTarget.Text = setting.Target;
                txtSource.Text = setting.Source;
                txtTranslatorSource.Text = setting.TranslatorSource;
                cbbGoogle.Checked = setting.IsGooogleUsing;
                cbbLanguage.SelectedItem = setting.Language;
                txtReport.Text = setting.ReportDir;
                if (cbbGoogle.Checked)
                {
                    translator = new GoogleTranslator();
                    txtTranslatorSource.Enabled = false;
                    btnChooseTranslatorFile.Visible = false;
                }
                else
                {
                    translator = new ExcelTranslator(txtTranslatorSource.Text);
                    txtTranslatorSource.Enabled = true;
                    btnChooseTranslatorFile.Visible = true;
                }
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
            if (!cbbGoogle.Checked && (!StringUtils.IsNotEmpty(txtTranslatorSource.Text) || !File.Exists(txtTranslatorSource.Text)))
            {
                MessageBox.Show("Nguồn dịch chưa nhập hoặc không tồn tại", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Translate(txtSource.Text, txtTarget.Text, ((string)cbbLanguage.SelectedItem).Split('-')[1]);
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
                    performance = new TitlePerformance();
                    string extraDir = dir.Replace(source, "").Replace("\\","");
                    var newPath = dest + "\\" + translator.Execute(extraDir, language);
                    Command.CopyFolder(dir, newPath);
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
                    //Translate(dir, dest + extraDir, language);
                }
            }
        }

        private string TranslateImageTitle(string filePath, string dest, string language)
        {
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }
            var fileName = Path.GetFileName(filePath);
            var extension = Path.GetExtension(filePath);
            dest = dest + "\\" + translator.Execute(fileName.Replace(extension,""), language).Trim()+extension;
            Command.CopyFile(filePath, dest);
            return dest;
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
                        compression.IsGooogleUsing = cbbGoogle.Checked;
                        compression.TranslatorSource = txtTranslatorSource.Text;
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
            string filePath = txtReport.Text + "\\Report_Translator_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            using (var writer = new StreamWriter(filePath, false, new UTF8Encoding(true)))
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

        private void btnChooseTranslatorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTranslatorSource.Text = openFileDialog.FileName;
            }
        }

        private void cbbGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbbGoogle.Checked)
            {
                translator = new GoogleTranslator();
                txtTranslatorSource.Enabled = false;
                btnChooseTranslatorFile.Visible = false;
            }
            else
            {
                translator = new ExcelTranslator(txtTranslatorSource.Text);
                txtTranslatorSource.Enabled = true;
                btnChooseTranslatorFile.Visible = true;
            }
        }
    }
}
