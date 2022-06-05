
namespace XOptimization
{
    partial class TitleUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleUC));
            this.txtSubTitle = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPriTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaxChar = new DevExpress.XtraEditors.SpinEdit();
            this.btnSaveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseSource = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSource = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.txtReport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxChar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubTitle
            // 
            this.txtSubTitle.Location = new System.Drawing.Point(885, 157);
            this.txtSubTitle.Name = "txtSubTitle";
            this.txtSubTitle.Size = new System.Drawing.Size(256, 98);
            this.txtSubTitle.TabIndex = 49;
            this.txtSubTitle.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(676, 160);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 17);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Tiêu đề phụ";
            // 
            // txtPriTitle
            // 
            this.txtPriTitle.Location = new System.Drawing.Point(885, 119);
            this.txtPriTitle.Name = "txtPriTitle";
            this.txtPriTitle.Size = new System.Drawing.Size(256, 22);
            this.txtPriTitle.TabIndex = 47;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(676, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 17);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Tiêu đề chính";
            // 
            // txtMaxChar
            // 
            this.txtMaxChar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaxChar.Location = new System.Drawing.Point(293, 194);
            this.txtMaxChar.Name = "txtMaxChar";
            this.txtMaxChar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaxChar.Size = new System.Drawing.Size(256, 24);
            this.txtMaxChar.TabIndex = 45;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveConfig.ImageOptions.SvgImage")));
            this.btnSaveConfig.Location = new System.Drawing.Point(717, 290);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(146, 41);
            this.btnSaveConfig.TabIndex = 44;
            this.btnSaveConfig.Text = "Lưu cấu hình";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(81, 198);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 17);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Số kí tự tối đa";
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseSource.ImageOptions.SvgImage")));
            this.btnChooseSource.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseSource.Location = new System.Drawing.Point(555, 119);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(27, 22);
            this.btnChooseSource.TabIndex = 42;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(869, 290);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 41);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(529, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 21);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "TẠO TIÊU ĐỀ";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(293, 157);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(256, 22);
            this.txtFormat.TabIndex = 38;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(81, 159);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 17);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Cấu trúc tiêu đề";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(293, 119);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(256, 22);
            this.txtSource.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 17);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Đường dẫn ảnh SP";
            // 
            // btnReport
            // 
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnReport.Location = new System.Drawing.Point(555, 233);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(27, 22);
            this.btnReport.TabIndex = 52;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(293, 233);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(256, 22);
            this.txtReport.TabIndex = 51;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(81, 235);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(132, 17);
            this.labelControl7.TabIndex = 50;
            this.labelControl7.Text = "Thư mục lưu báo cáo";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(979, 290);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(162, 41);
            this.btnExport.TabIndex = 53;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // TitleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtSubTitle);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPriTitle);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMaxChar);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnChooseSource);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.labelControl1);
            this.Name = "TitleUC";
            this.Size = new System.Drawing.Size(1232, 401);
            ((System.ComponentModel.ISupportInitialize)(this.txtPriTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxChar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSubTitle;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPriTitle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit txtMaxChar;
        private DevExpress.XtraEditors.SimpleButton btnSaveConfig;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnChooseSource;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFormat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.TextEdit txtReport;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}
