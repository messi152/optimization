﻿
namespace XOptimization
{
    partial class TranslationUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslationUC));
            this.btnSaveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.cbbLanguage = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseTarget = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseSource = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarget = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSource = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.txtReport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveConfig.ImageOptions.SvgImage")));
            this.btnSaveConfig.Location = new System.Drawing.Point(149, 264);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(154, 41);
            this.btnSaveConfig.TabIndex = 28;
            this.btnSaveConfig.Text = "Lưu cấu hình";
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // cbbLanguage
            // 
            this.cbbLanguage.FormattingEnabled = true;
            this.cbbLanguage.Location = new System.Drawing.Point(300, 178);
            this.cbbLanguage.Name = "cbbLanguage";
            this.cbbLanguage.Size = new System.Drawing.Size(121, 24);
            this.cbbLanguage.TabIndex = 27;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(88, 181);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 17);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Ngôn ngữ chuyển";
            // 
            // btnChooseTarget
            // 
            this.btnChooseTarget.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseTarget.ImageOptions.SvgImage")));
            this.btnChooseTarget.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseTarget.Location = new System.Drawing.Point(562, 142);
            this.btnChooseTarget.Name = "btnChooseTarget";
            this.btnChooseTarget.Size = new System.Drawing.Size(27, 22);
            this.btnChooseTarget.TabIndex = 25;
            this.btnChooseTarget.Click += new System.EventHandler(this.btnChooseTarget_Click);
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseSource.ImageOptions.SvgImage")));
            this.btnChooseSource.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseSource.Location = new System.Drawing.Point(562, 106);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(27, 22);
            this.btnChooseSource.TabIndex = 24;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(309, 264);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 41);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(202, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(241, 21);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "TẠO TIÊU ĐỀ ĐA NGÔN NGỮ";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(300, 142);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(256, 22);
            this.txtTarget.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(88, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 17);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Đường dẫn đích";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(300, 106);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(256, 22);
            this.txtSource.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(88, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 17);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Đường dẫn nguồn";
            // 
            // btnReport
            // 
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnReport.Location = new System.Drawing.Point(562, 215);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(27, 22);
            this.btnReport.TabIndex = 31;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(300, 215);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(256, 22);
            this.txtReport.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(88, 217);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(132, 17);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Thư mục lưu báo cáo";
            // 
            // btnExport
            // 
            this.btnExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExport.ImageOptions.SvgImage")));
            this.btnExport.Location = new System.Drawing.Point(427, 264);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(162, 41);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // TranslationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.cbbLanguage);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnChooseTarget);
            this.Controls.Add(this.btnChooseSource);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.labelControl1);
            this.Name = "TranslationUC";
            this.Size = new System.Drawing.Size(713, 372);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveConfig;
        private System.Windows.Forms.ComboBox cbbLanguage;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnChooseTarget;
        private DevExpress.XtraEditors.SimpleButton btnChooseSource;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTarget;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.TextEdit txtReport;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}