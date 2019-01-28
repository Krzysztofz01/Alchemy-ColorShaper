namespace Alchemy_ColorShaper
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
            this.picPanel = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnShape = new System.Windows.Forms.Button();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.colorPanel2 = new System.Windows.Forms.Panel();
            this.colorPanel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // picPanel
            // 
            this.picPanel.Location = new System.Drawing.Point(12, 12);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(392, 218);
            this.picPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPanel.TabIndex = 0;
            this.picPanel.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 236);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnShape
            // 
            this.btnShape.Location = new System.Drawing.Point(166, 236);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(75, 23);
            this.btnShape.TabIndex = 2;
            this.btnShape.Text = "Shape";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // colorPanel1
            // 
            this.colorPanel1.Location = new System.Drawing.Point(12, 265);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(105, 105);
            this.colorPanel1.TabIndex = 3;
            // 
            // colorPanel2
            // 
            this.colorPanel2.Location = new System.Drawing.Point(153, 265);
            this.colorPanel2.Name = "colorPanel2";
            this.colorPanel2.Size = new System.Drawing.Size(105, 105);
            this.colorPanel2.TabIndex = 4;
            // 
            // colorPanel3
            // 
            this.colorPanel3.Location = new System.Drawing.Point(299, 265);
            this.colorPanel3.Name = "colorPanel3";
            this.colorPanel3.Size = new System.Drawing.Size(105, 105);
            this.colorPanel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(416, 449);
            this.Controls.Add(this.colorPanel3);
            this.Controls.Add(this.colorPanel2);
            this.Controls.Add(this.colorPanel1);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.picPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Alchemy-ColorShaper";
            ((System.ComponentModel.ISupportInitialize)(this.picPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPanel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.Panel colorPanel1;
        private System.Windows.Forms.Panel colorPanel2;
        private System.Windows.Forms.Panel colorPanel3;
    }
}

