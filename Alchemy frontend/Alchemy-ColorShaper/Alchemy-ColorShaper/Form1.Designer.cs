namespace Alchemy_ColorShaper
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
            this.topBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.topBar.Controls.Add(this.btnMin);
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.Controls.Add(this.titleLabel);
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(712, 25);
            this.topBar.TabIndex = 1;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.titleLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(269, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 21);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Alchemy-ColorShaper";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(689, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(665, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(18, 21);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "_";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alchemy-ColorShaper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnMin;
    }
}

