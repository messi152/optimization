using CsvHelper;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOptimization
{
    public partial class CompressionUC : UserControl
    {
        Main main;
        List<CompressionPerformance> logs;
        public CompressionUC()
        {
            InitializeComponent();
            Init();
        }
        public CompressionUC(Main main)
        {
            InitializeComponent();
            this.main = main;
            Init();
        }

        private void Init()
        {
            cbbCompressQuality.Items.Clear();
            for (int i = 10; i <= 100; i = i + 10)
            {
                cbbCompressQuality.Items.Add(i);
            }
            cbbCompressQuality.SelectedIndex = 4;
            try { 
                CompressionInfo setting = JsonConvert.DeserializeObject<CompressionInfo>(File.ReadAllText(Helper.GetCurrentDirectory() + "\\Data\\compression.json"));
                txtTarget.Text = setting.Target;
                txtSource.Text = setting.Source;
                txtReport.Text = setting.ReportDir;
                cbbCompressQuality.Text = setting.Quality.ToString();
            }
            catch (Exception)
            {
            }
            logs = new List<CompressionPerformance>();
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
            Compress(txtSource.Text, txtTarget.Text, (int)cbbCompressQuality.SelectedItem);
            SplashScreenManager.CloseForm();
            MessageBox.Show("Ảnh nén đã được lưu vào trong thư mục:\n" + txtTarget.Text, "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Compress(string source, string dest, int quality)
        {

            string[] files = Directory.GetFiles(source);
            foreach (var file in files)
            {
                string ext = Path.GetExtension(file).ToUpper();
                if (ext == ".PNG" || ext == ".JPG" || ext == ".JPEG")
                    CompressImage(file, dest, quality);
            }
            List<String> subDirs = Helper.GetSubDirectories(source);
            if (subDirs!=null && subDirs.Count > 0)
            {
                foreach(String dir in subDirs)
                {
                    string extraDir = dir.Replace(source, "");
                    Compress(dir, dest+extraDir, quality);
                }
            }
        }
        private void CompressImage(string filePath, string dest, int quality)
        {
            CompressionPerformance performance = new CompressionPerformance();
            try {
                if (!Directory.Exists(dest))
                {
                    Directory.CreateDirectory(dest);
                }
                var fileName = Path.GetFileName(filePath);
                dest = dest + "\\" + fileName;

                using (Bitmap bitmap = new Bitmap(filePath))
                {
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                    System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;

                    EncoderParameters encoderParas = new EncoderParameters(1);

                    EncoderParameter encoderPara = new EncoderParameter(qualityEncoder, quality);

                    encoderParas.Param[0] = encoderPara;
                    bitmap.Save(dest, jpgEncoder, encoderParas);

                }
            }
            catch(Exception e)
            {
                performance.Note = "Lỗi nén file:"+e.Message;
            }

            long sourceSize = GetFileSize(filePath);
            long destSize = GetFileSize(dest);
            performance.Source = filePath;
            performance.SourceSize = sourceSize.ToString("#.#").ToString()+" KB";
            if (!StringUtils.IsNotEmpty(performance.Note))
            {
                performance.Dest = dest;
                performance.DestSize = destSize.ToString("#.#").ToString() + " KB";
                performance.Change = ((((decimal)sourceSize- (decimal)destSize) / (decimal)sourceSize)*100).ToString("##.##") + " %";
            }
            logs.Add(performance);
        }
        private long GetFileSize(string filePath)
        {
            if (File.Exists(filePath))
            {
                return new FileInfo(filePath).Length/1024;
            }
            return 0;
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (MessageBox.Show("Bạn có muốn lưu cấu hình này không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        CompressionInfo compression = new CompressionInfo();
                        compression.Source = txtSource.Text;
                        compression.Target = txtTarget.Text;
                        compression.ReportDir = txtReport.Text;
                        compression.Quality = (int)cbbCompressQuality.SelectedItem;
                        Helper.WriteText(Helper.GetCurrentDirectory() + "\\Data\\compression.json", JsonConvert.SerializeObject(compression, Newtonsoft.Json.Formatting.Indented));
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
            string filePath = txtReport.Text + "\\Report_Compression_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
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
    }
}
