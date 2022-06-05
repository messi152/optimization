using DevExpress.XtraBars;
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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            if (!Directory.Exists(XOptimization.Helper.GetCurrentDirectory()+"\\Data"))
            {
                Directory.CreateDirectory(XOptimization.Helper.GetCurrentDirectory()+"\\Data");
            }
        }

        private void btnCompress_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Controls.Add(new CompressionUC(this));
            pcMain.Refresh();
        }

        private void btnCompressionReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Controls.Add(new TitleUC(this));
            pcMain.Refresh();
        }

        private void btnCreateTitle_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Controls.Add(new TitleUC(this));
            pcMain.Refresh();
        }

        private void btnTranslate_ItemClick(object sender, ItemClickEventArgs e)
        {
            pcMain.Controls.Clear();
            pcMain.Controls.Add(new TranslatorUC(this));
            pcMain.Controls.Add(new TranslatorUC(this));
            pcMain.Refresh();
        }
    }
}