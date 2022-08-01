using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOptimization
{
    public partial class ReplacingTitle : UserControl
    {
        public ReplacingTitle()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            Copy(txtSource.Text,txtOutput.Text);
            MessageBox.Show("Thay thế tiêu đề ảnh thành công", "Tin nhắn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Copy(string path, string dest)
        {
            if (!Directory.Exists(path)) return;
            if (!Directory.Exists(dest)) return;
            string[] files = Directory.GetFiles(path);
            if (files != null && files.Count() > 0)
            {
                foreach (String file in files)
                {
                    String fileName = Path.GetFileName(file);
                    Command.CopyFile(file, dest+"\\"+fileName.Replace(txtContent.Text,txtReplace.Text));
                }
            }
            List<String> subDirs = Helper.GetSubDirectories(path);
            if (subDirs != null && subDirs.Count > 0)
            {
                foreach (String dir in subDirs)
                {
                    Copy(dir, dest);
                }
            }
        }

        private void btnChooseDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOutput.Text = folderBrowserDialog.SelectedPath;
            }
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
                MessageBox.Show("Cần nhập đường dẫn ảnh SP", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtOutput.Text))
            {
                MessageBox.Show("Cần nhập đường dẫn kết quả", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtContent.Text))
            {
                MessageBox.Show("Cần nhập nội dung cần thay thế", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringUtils.IsNotEmpty(txtReplace.Text))
            {
                MessageBox.Show("Cần nhập nội dung thay thế", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
