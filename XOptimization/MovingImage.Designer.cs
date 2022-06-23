
namespace XOptimization
{
    partial class MovingImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovingImage));
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseDest = new DevExpress.XtraEditors.SimpleButton();
            this.txtOutput = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnChooseSource = new DevExpress.XtraEditors.SimpleButton();
            this.txtSource = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(241, 147);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(18, 16);
            this.labelControl14.TabIndex = 71;
            this.labelControl14.Text = "(*)";
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseDest.ImageOptions.SvgImage")));
            this.btnChooseDest.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseDest.Location = new System.Drawing.Point(566, 144);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(27, 22);
            this.btnChooseDest.TabIndex = 70;
            this.btnChooseDest.Click += new System.EventHandler(this.btnChooseDest_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(304, 144);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(256, 22);
            this.txtOutput.TabIndex = 69;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(92, 147);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(120, 17);
            this.labelControl15.TabIndex = 68;
            this.labelControl15.Text = "Đường dẫn kết quả";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(241, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 16);
            this.labelControl8.TabIndex = 67;
            this.labelControl8.Text = "(*)";
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChooseSource.ImageOptions.SvgImage")));
            this.btnChooseSource.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btnChooseSource.Location = new System.Drawing.Point(566, 107);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(27, 22);
            this.btnChooseSource.TabIndex = 66;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(304, 107);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(256, 22);
            this.txtSource.TabIndex = 65;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(92, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 17);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Đường dẫn ảnh SP";
            // 
            // btnCreate
            // 
            this.btnCreate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreate.ImageOptions.SvgImage")));
            this.btnCreate.Location = new System.Drawing.Point(419, 209);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(174, 41);
            this.btnCreate.TabIndex = 72;
            this.btnCreate.Text = "Di chuyển";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(304, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 21);
            this.labelControl3.TabIndex = 73;
            this.labelControl3.Text = "DI CHUYỂN ẢNH";
            // 
            // MovingImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.btnChooseDest);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnChooseSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.labelControl1);
            this.Name = "MovingImage";
            this.Size = new System.Drawing.Size(712, 328);
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSource.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnChooseDest;
        private DevExpress.XtraEditors.TextEdit txtOutput;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnChooseSource;
        private DevExpress.XtraEditors.TextEdit txtSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
