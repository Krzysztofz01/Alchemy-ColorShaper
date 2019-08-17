namespace Alchemy_ColorShaper2
{
    partial class mainWindow
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
            this.btnImportImage = new System.Windows.Forms.Button();
            this.btnStartProcessing = new System.Windows.Forms.Button();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.tbResolution = new System.Windows.Forms.TrackBar();
            this.tbCompression = new System.Windows.Forms.TrackBar();
            this.tbAccuracy = new System.Windows.Forms.TrackBar();
            this.txtThreshold = new System.Windows.Forms.Label();
            this.txtResolution = new System.Windows.Forms.Label();
            this.txtCompression = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportImage
            // 
            this.btnImportImage.Location = new System.Drawing.Point(12, 12);
            this.btnImportImage.Name = "btnImportImage";
            this.btnImportImage.Size = new System.Drawing.Size(300, 38);
            this.btnImportImage.TabIndex = 0;
            this.btnImportImage.Text = "Import";
            this.btnImportImage.UseVisualStyleBackColor = true;
            this.btnImportImage.Click += new System.EventHandler(this.BtnImportImage_Click);
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Enabled = false;
            this.btnStartProcessing.Location = new System.Drawing.Point(12, 308);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(300, 38);
            this.btnStartProcessing.TabIndex = 1;
            this.btnStartProcessing.Text = "Start";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            this.btnStartProcessing.Click += new System.EventHandler(this.BtnStartProcessing_Click);
            // 
            // tbThreshold
            // 
            this.tbThreshold.LargeChange = 10;
            this.tbThreshold.Location = new System.Drawing.Point(38, 69);
            this.tbThreshold.Maximum = 100;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(249, 45);
            this.tbThreshold.TabIndex = 2;
            this.tbThreshold.TickFrequency = 10;
            this.tbThreshold.Value = 50;
            this.tbThreshold.Scroll += new System.EventHandler(this.TbThreshold_Scroll);
            // 
            // tbResolution
            // 
            this.tbResolution.LargeChange = 200;
            this.tbResolution.Location = new System.Drawing.Point(38, 120);
            this.tbResolution.Maximum = 1000;
            this.tbResolution.Minimum = 200;
            this.tbResolution.Name = "tbResolution";
            this.tbResolution.Size = new System.Drawing.Size(249, 45);
            this.tbResolution.SmallChange = 100;
            this.tbResolution.TabIndex = 3;
            this.tbResolution.TickFrequency = 100;
            this.tbResolution.Value = 600;
            this.tbResolution.Scroll += new System.EventHandler(this.TbResolution_Scroll);
            // 
            // tbCompression
            // 
            this.tbCompression.LargeChange = 10;
            this.tbCompression.Location = new System.Drawing.Point(38, 171);
            this.tbCompression.Maximum = 100;
            this.tbCompression.Minimum = 2;
            this.tbCompression.Name = "tbCompression";
            this.tbCompression.Size = new System.Drawing.Size(249, 45);
            this.tbCompression.TabIndex = 4;
            this.tbCompression.TickFrequency = 10;
            this.tbCompression.Value = 50;
            this.tbCompression.Scroll += new System.EventHandler(this.TbCompression_Scroll);
            // 
            // tbAccuracy
            // 
            this.tbAccuracy.LargeChange = 1;
            this.tbAccuracy.Location = new System.Drawing.Point(38, 222);
            this.tbAccuracy.Maximum = 5;
            this.tbAccuracy.Minimum = 1;
            this.tbAccuracy.Name = "tbAccuracy";
            this.tbAccuracy.Size = new System.Drawing.Size(249, 45);
            this.tbAccuracy.TabIndex = 5;
            this.tbAccuracy.Value = 1;
            this.tbAccuracy.Scroll += new System.EventHandler(this.TbAccuracy_Scroll);
            // 
            // txtThreshold
            // 
            this.txtThreshold.AutoSize = true;
            this.txtThreshold.Location = new System.Drawing.Point(142, 101);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(40, 13);
            this.txtThreshold.TabIndex = 6;
            this.txtThreshold.Text = "sample";
            // 
            // txtResolution
            // 
            this.txtResolution.AutoSize = true;
            this.txtResolution.Location = new System.Drawing.Point(142, 152);
            this.txtResolution.Name = "txtResolution";
            this.txtResolution.Size = new System.Drawing.Size(40, 13);
            this.txtResolution.TabIndex = 7;
            this.txtResolution.Text = "sample";
            // 
            // txtCompression
            // 
            this.txtCompression.AutoSize = true;
            this.txtCompression.Location = new System.Drawing.Point(142, 203);
            this.txtCompression.Name = "txtCompression";
            this.txtCompression.Size = new System.Drawing.Size(40, 13);
            this.txtCompression.TabIndex = 8;
            this.txtCompression.Text = "sample";
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.AutoSize = true;
            this.txtAccuracy.Location = new System.Drawing.Point(142, 254);
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(40, 13);
            this.txtAccuracy.TabIndex = 9;
            this.txtAccuracy.Text = "sample";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 359);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.txtCompression);
            this.Controls.Add(this.txtResolution);
            this.Controls.Add(this.txtThreshold);
            this.Controls.Add(this.tbAccuracy);
            this.Controls.Add(this.tbCompression);
            this.Controls.Add(this.tbResolution);
            this.Controls.Add(this.tbThreshold);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.btnImportImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alchemy-ColorShaper";
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCompression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportImage;
        private System.Windows.Forms.Button btnStartProcessing;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.TrackBar tbResolution;
        private System.Windows.Forms.TrackBar tbCompression;
        private System.Windows.Forms.TrackBar tbAccuracy;
        private System.Windows.Forms.Label txtThreshold;
        private System.Windows.Forms.Label txtResolution;
        private System.Windows.Forms.Label txtCompression;
        private System.Windows.Forms.Label txtAccuracy;
    }
}