
namespace XOptimization
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCompressionReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompress = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateTitle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTranslate = new DevExpress.XtraBars.BarButtonItem();
            this.btnTitleReport = new DevExpress.XtraBars.BarButtonItem();
            this.compressTab = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.TitleTab = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pcMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnCompressionReport,
            this.btnCompress,
            this.btnCreateTitle,
            this.btnTranslate,
            this.btnTitleReport});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.compressTab,
            this.TitleTab});
            this.ribbon.Size = new System.Drawing.Size(1133, 214);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnCompressionReport
            // 
            this.btnCompressionReport.Caption = "Báo cáo";
            this.btnCompressionReport.Id = 1;
            this.btnCompressionReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompressionReport.ImageOptions.SvgImage")));
            this.btnCompressionReport.Name = "btnCompressionReport";
            this.btnCompressionReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompressionReport_ItemClick);
            // 
            // btnCompress
            // 
            this.btnCompress.Caption = "Nén ảnh";
            this.btnCompress.Id = 2;
            this.btnCompress.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCompress.ImageOptions.SvgImage")));
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompress_ItemClick);
            // 
            // btnCreateTitle
            // 
            this.btnCreateTitle.Caption = "Tạo tiêu đề";
            this.btnCreateTitle.Id = 3;
            this.btnCreateTitle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateTitle.ImageOptions.SvgImage")));
            this.btnCreateTitle.Name = "btnCreateTitle";
            this.btnCreateTitle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateTitle_ItemClick);
            // 
            // btnTranslate
            // 
            this.btnTranslate.Caption = "Dịch tiêu đề";
            this.btnTranslate.Id = 4;
            this.btnTranslate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTranslate.ImageOptions.SvgImage")));
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTranslate_ItemClick);
            // 
            // btnTitleReport
            // 
            this.btnTitleReport.Caption = "Báo cáo";
            this.btnTitleReport.Id = 5;
            this.btnTitleReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTitleReport.ImageOptions.SvgImage")));
            this.btnTitleReport.Name = "btnTitleReport";
            // 
            // compressTab
            // 
            this.compressTab.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.compressTab.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("compressTab.ImageOptions.SvgImage")));
            this.compressTab.Name = "compressTab";
            this.compressTab.Text = "Nén ảnh";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompress);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thực hiện";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCompressionReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thống kê";
            // 
            // TitleTab
            // 
            this.TitleTab.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.TitleTab.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TitleTab.ImageOptions.SvgImage")));
            this.TitleTab.Name = "TitleTab";
            this.TitleTab.Text = "Tạo tiêu đề";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCreateTitle);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTranslate);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thực hiện";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTitleReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống kê";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 638);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1133, 28);
            // 
            // pcMain
            // 
            this.pcMain.Location = new System.Drawing.Point(12, 220);
            this.pcMain.Name = "pcMain";
            this.pcMain.Size = new System.Drawing.Size(1109, 412);
            this.pcMain.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 666);
            this.Controls.Add(this.pcMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage compressTab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage TitleTab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnCompressionReport;
        private DevExpress.XtraBars.BarButtonItem btnCompress;
        private DevExpress.XtraBars.BarButtonItem btnCreateTitle;
        private DevExpress.XtraBars.BarButtonItem btnTranslate;
        private DevExpress.XtraBars.BarButtonItem btnTitleReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Panel pcMain;
    }
}