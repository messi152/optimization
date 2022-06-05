﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOptimization
{
    public partial class TitleUC : UserControl
    {
        List<TitlePerformance> logs;
        private Main main;
        public TitleUC()
        {
            InitializeComponent();
        }
        public TitleUC(Main main)
        {
            InitializeComponent();
            this.main = main;
            Init();
        }
        private enum TYPE
        {
            FOLDER,
            FILE
        }
        private void Init()
        {
            try
            {
                TitleInfo setting = JsonConvert.DeserializeObject<TitleInfo>(File.ReadAllText(Helper.GetCurrentDirectory() + "\\Data\\title.json"));
                txtSource.Text = setting.Source;
                txtMaxChar.Text = setting.MaxOfCharacter.ToString();
                txtFormat.Text = setting.Format;
                txtPriTitle.Text = setting.PriTitle;
                txtSubTitle.Text = setting.SubTitle;
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

        private bool ValidateData()
        {
            if (!StringUtils.IsNotEmpty(txtSource.Text))
            {
                MessageBox.Show("Cần nhập đường dẫn nguồn", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtFormat.Text))
            {
                MessageBox.Show("Cần nhập cấu trúc tiêu đề", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("Đường dẫn nguồn không tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtPriTitle.Text))
            {
                MessageBox.Show("Cần nhập tiêu đề chính", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtSubTitle.Text))
            {
                MessageBox.Show("Cần nhập tiêu đề phụ", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtMaxChar.Text))
            {
                MessageBox.Show("Cần nhập số kí tự tối đa", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int countFormat = 0, countSub = 0;
            txtFormat.Text.Split(new[] { "+" }, StringSplitOptions.None).ToList().ForEach(item => countFormat = (StringUtils.IsNotEmpty(item) && item.Equals("{sub}")) ? countFormat + 1 : countFormat);
            txtSubTitle.Text.Split(new[] { "," }, StringSplitOptions.None).ToList().ForEach(item => countSub = (StringUtils.IsNotEmpty(item)) ? countSub + 1 : countSub);
            if (countFormat > countSub)
            {
                MessageBox.Show("Cần bổ sung thêm tiêu đề phụ phù hợp với cấu trúc tiêu đề", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string[] files = Directory.GetFiles(txtSource.Text);
            if (files != null && files.Count() > 0)
            {
                foreach (String file in files)
                {
                    ChangeTitle(TYPE.FILE, file);
                }
            }
            ChangeTitle(txtSource.Text);
            MessageBox.Show("Tạo tiêu đề thành công", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void ChangeTitle(string path)
        {
            if (!Directory.Exists(path)) return;
            List<String> subDirs = Helper.GetSubDirectories(path);
            if (subDirs != null && subDirs.Count > 0)
            {
                foreach (String dir in subDirs)
                {
                    ChangeTitle(dir);
                    ChangeTitle(TYPE.FOLDER, dir);
                }
            }
        }
        private void ChangeTitle(TYPE type, string path)
        {

            TitlePerformance performance = new TitlePerformance();
            //Xác định cấu trúc
            string result = "";
            string newPath = "";
            try
            {
                List<string> subs = new List<string>();
                string[] subArrs = txtSubTitle.Text.Split(new[] { "," }, StringSplitOptions.None);
                foreach (string sub in subArrs)
                {
                    if (StringUtils.IsNotEmpty(sub))
                        subs.Add(sub.Trim().Replace("\n", "").Replace("\r", ""));
                }
                string[] formats = txtFormat.Text.Split(new[] { "+" }, StringSplitOptions.None);
                List<string> titleList = new List<string>();
                if (formats != null && formats.Count() > 0)
                {
                    foreach (String item in formats)
                    {
                        if (item.Trim() == "{main}") result += txtPriTitle.Text + " ";
                        else
                        {
                            Random ran = new Random();
                            if (subs != null && subs.Count() > 0)
                            {
                                string sub = subs[ran.Next(0, 100) % (subs.Count)].Trim();
                                if (item.Trim() == "{sub}") result += sub + " ";
                                subs.Remove(sub);
                            }
                        }
                    }
                }
                if (Convert.ToInt32(txtMaxChar.Text) < result.Length)
                    result = result.Substring(0, Convert.ToInt32(txtMaxChar.Text));
                if (type == TYPE.FILE)
                {
                    newPath = Command.RenameFile(path, result);
                }
                else
                {
                    newPath = Command.RenameFolder(path, result);
                }
                if (path.Equals(newPath))
                {
                    performance.Note = "Lỗi tạo tiêu đề";
                }
            }
            catch(Exception e)
            {
                performance.Note = "Lỗi tạo tiêu đề:" + e.Message;
            }
            performance.Source = path;
            performance.SourceName = new FileInfo(path).Name;
            if (!StringUtils.IsNotEmpty(performance.Note))
            {
                performance.Dest = newPath;
                performance.DestName = new FileInfo(newPath).Name;
            }
            logs.Add(performance);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (MessageBox.Show("Bạn có muốn lưu cấu hình này không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        TitleInfo setting = new TitleInfo();
                        setting.Source = txtSource.Text;
                        setting.MaxOfCharacter = Convert.ToInt32(txtMaxChar.Text);
                        setting.Format = txtFormat.Text;
                        setting.PriTitle = txtPriTitle.Text;
                        setting.SubTitle = txtSubTitle.Text;
                        setting.ReportDir = txtReport.Text;
                        Helper.WriteText(Helper.GetCurrentDirectory() + "\\Data\\title.json", JsonConvert.SerializeObject(setting, Newtonsoft.Json.Formatting.Indented));
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
