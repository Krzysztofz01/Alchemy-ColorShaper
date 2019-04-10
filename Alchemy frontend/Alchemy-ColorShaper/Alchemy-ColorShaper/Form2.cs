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
