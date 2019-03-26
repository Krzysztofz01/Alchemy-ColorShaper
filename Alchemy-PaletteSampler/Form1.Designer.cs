namespace Alchemy_PaletteSampler
{
    partial class Form1
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSample = new System.Windows.Forms.Button();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.colorPanel2 = new System.Windows.Forms.Panel();
            this.colorPanel4 = new System.Windows.Forms.Panel();
            this.colorPanel3 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.colorText1 = new System.Windows.Forms.Label();
            this.colorText2 = new System.Windows.Forms.Label();
            this.colorText3 = new System.Windows.Forms.Label();
            this.colorText4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.colorPanel1.SuspendLayout();
            this.colorPanel2.SuspendLayout();
            this.colorPanel4.SuspendLayout();
            this.colorPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Gray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(11, 11);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 57);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(679, 372);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnSample
            // 
            this.btnSample.BackColor = System.Drawing.Color.Gray;
            this.btnSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSample.Location = new System.Drawing.Point(106, 11);
            this.btnSample.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(81, 33);
            this.btnSample.TabIndex = 2;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = false;
            this.btnSample.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPanel1
            // 
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.Controls.Add(this.colorText1);
            this.colorPanel1.Location = new System.Drawing.Point(11, 448);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(115, 115);
            this.colorPanel1.TabIndex = 3;
            this.colorPanel1.Visible = false;
            // 
            // colorPanel2
            // 
            this.colorPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel2.Controls.Add(this.colorText2);
            this.colorPanel2.Location = new System.Drawing.Point(202, 448);
            this.colorPanel2.Name = "colorPanel2";
            this.colorPanel2.Size = new System.Drawing.Size(115, 115);
            this.colorPanel2.TabIndex = 4;
            this.colorPanel2.Visible = false;
            // 
            // colorPanel4
            // 
            this.colorPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel4.Controls.Add(this.colorText4);
            this.colorPanel4.Location = new System.Drawing.Point(574, 448);
            this.colorPanel4.Name = "colorPanel4";
            this.colorPanel4.Size = new System.Drawing.Size(115, 115);
            this.colorPanel4.TabIndex = 4;
            this.colorPanel4.Visible = false;
            // 
            // colorPanel3
            // 
            this.colorPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel3.Controls.Add(this.colorText3);
            this.colorPanel3.Location = new System.Drawing.Point(390, 448);
            this.colorPanel3.Name = "colorPanel3";
            this.colorPanel3.Size = new System.Drawing.Size(115, 115);
            this.colorPanel3.TabIndex = 4;
            this.colorPanel3.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.ForeColor = System.Drawing.Color.Gray;
            this.progressBar.Location = new System.Drawing.Point(217, 11);
            this.progressBar.MarqueeAnimationSpeed = 25;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 33);
            this.progressBar.Step = 25;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // colorText1
            // 
            this.colorText1.AutoSize = true;
            this.colorText1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorText1.Location = new System.Drawing.Point(3, 95);
            this.colorText1.Name = "colorText1";
            this.colorText1.Size = new System.Drawing.Size(0, 18);
            this.colorText1.TabIndex = 0;
            // 
            // colorText2
            // 
            this.colorText2.AutoSize = true;
            this.colorText2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorText2.Location = new System.Drawing.Point(3, 95);
            this.colorText2.Name = "colorText2";
            this.colorText2.Size = new System.Drawing.Size(0, 18);
            this.colorText2.TabIndex = 1;
            // 
            // colorText3
            // 
            this.colorText3.AutoSize = true;
            this.colorText3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorText3.Location = new System.Drawing.Point(3, 95);
            this.colorText3.Name = "colorText3";
            this.colorText3.Size = new System.Drawing.Size(0, 18);
            this.colorText3.TabIndex = 2;
            // 
            // colorText4
            // 
            this.colorText4.AutoSize = true;
            this.colorText4.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorText4.Location = new System.Drawing.Point(3, 95);
            this.colorText4.Name = "colorText4";
            this.colorText4.Size = new System.Drawing.Size(0, 18);
            this.colorText4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 575);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.colorPanel3);
            this.Controls.Add(this.colorPanel4);
            this.Controls.Add(this.colorPanel2);
            this.Controls.Add(this.colorPanel1);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSelect);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alchemy - PaletteSampler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.colorPanel1.ResumeLayout(false);
            this.colorPanel1.PerformLayout();
            this.colorPanel2.ResumeLayout(false);
            this.colorPanel2.PerformLayout();
            this.colorPanel4.ResumeLayout(false);
            this.colorPanel4.PerformLayout();
            this.colorPanel3.ResumeLayout(false);
            this.colorPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Panel colorPanel1;
        private System.Windows.Forms.Panel colorPanel2;
        private System.Windows.Forms.Panel colorPanel4;
        private System.Windows.Forms.Panel colorPanel3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label colorText1;
        private System.Windows.Forms.Label colorText2;
        private System.Windows.Forms.Label colorText4;
        private System.Windows.Forms.Label colorText3;
    }
}

