
namespace XOptimization
{
    partial class CompressionUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompressionUC));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSource = new DevExpress.XtraEditors.TextEdit();
            this.txtTarget = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseSource = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseTarget = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbCompressQuality = new System.Windows.Forms.ComboBox();
            this.btnSaveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.txtReport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đường dẫn nguồn";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(291, 103);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(256, 22);
            this.txtSource.TabIndex = 1;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(291, 139);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(256, 22);
            this.txtTarget.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(79, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đường dẫn đích";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(294, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 21);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "NÉN ẢNH";
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(294, 267);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 41);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Nén";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseSource.ImageOptions.SvgImage")));
            this.btnChooseSource.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseSource.Location = new System.Drawing.Point(553, 103);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(27, 22);
            this.btnChooseSource.TabIndex = 11;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // btnChooseTarget
            // 
            this.btnChooseTarget.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseTarget.ImageOptions.SvgImage")));
            this.btnChooseTarget.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseTarget.Location = new System.Drawing.Point(553, 139);
            this.btnChooseTarget.Name = "btnChooseTarget";
            this.btnChooseTarget.Size = new System.Drawing.Size(27, 22);
            this.btnChooseTarget.TabIndex = 13;
            this.btnChooseTarget.Click += new System.EventHandler(this.btnChooseTarget_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(79, 178);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Chất lượng nén";
            // 
            // cbbCompressQuality
            // 
            this.cbbCompressQuality.FormattingEnabled = true;
            this.cbbCompressQuality.Location = new System.Drawing.Point(291, 175);
            this.cbbCompressQuality.Name = "cbbCompressQuality";
            this.cbbCompressQuality.Size = new System.Drawing.Size(121, 24);
            this.cbbCompressQuality.TabIndex = 16;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveConfig.ImageOptions.SvgImage")));
            this.btnSaveConfig.Location = new System.Drawing.Point(110, 267);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(177, 41);
            this.btnSaveConfig.TabIndex = 17;
            this.btnSaveConfig.Text = "Lưu cấu hình";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnReport
            // 
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnReport.Location = new System.Drawing.Point(553, 213);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(27, 22);
            this.btnReport.TabIndex = 20;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(291, 213);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(256, 22);
            this.txtReport.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(79, 215);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 17);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Thư mục lưu báo cáo";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(410, 267);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(170, 41);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(226, 107);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 16);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "(*)";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(203, 141);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 16);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(203, 183);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 16);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "(*)";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(244, 215);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(18, 16);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "(*)";
            // 
            // CompressionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.cbbCompressQuality);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnChooseTarget);
            this.Controls.Add(this.btnChooseSource);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.labelControl1);
            this.Name = "CompressionUC";
            this.Size = new System.Drawing.Size(687, 373);
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSource;
        private DevExpress.XtraEditors.TextEdit txtTarget;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnChooseSource;
        private DevExpress.XtraEditors.SimpleButton btnChooseTarget;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbbCompressQuality;
        private DevExpress.XtraEditors.SimpleButton btnSaveConfig;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.TextEdit txtReport;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}
