using System;
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
