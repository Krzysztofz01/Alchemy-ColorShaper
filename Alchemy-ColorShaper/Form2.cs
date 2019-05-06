using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Alchemy_ColorShaper
{
    public partial class outputWindow : Form
    {
        private int mov, movY, movX;

        public outputWindow()
        {
            InitializeComponent();
        }

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            { 
                System.Environment.Exit(1);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void outputWindow_Load(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = Data.imageLocation;

            panel1.BackColor = Alchemy.hextoColor(Data.colors[0]);
            label1.Text = Data.colors[0];
            panel2.BackColor = Alchemy.hextoColor(Data.colors[1]);
            label2.Text = Data.colors[1];
            panel3.BackColor = Alchemy.hextoColor(Data.colors[2]);
            label3.Text = Data.colors[2];
            panel4.BackColor = Alchemy.hextoColor(Data.colors[3]);
            label4.Text = Data.colors[3];
            panel5.BackColor = Alchemy.hextoColor(Data.colors[4]);
            label5.Text = Data.colors[4];
            panel6.BackColor = Alchemy.hextoColor(Data.colors[5]);
            label6.Text = Data.colors[5];
            panel7.BackColor = Alchemy.hextoColor(Data.colors[6]);
            label7.Text = Data.colors[6];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[0]);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[1]);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[2]);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[3]);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[4]);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[5]);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Clipboard.SetText(Data.colors[6]);
        }

        private void BtnSave_Click(object sender, EventArgs e) => Export.exportAsImage();

        private void Label9_Click(object sender, EventArgs e)
        {
            Process.Start("Alchemy-ColorShaper.exe");
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void topBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void topBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
