﻿using Alchemy_PaletteSampler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Alchemy_ColorShaper
{
    public partial class mainWindow : Form
    {
        private int mov, movX, movY;

        public mainWindow()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(1500);
            InitializeComponent();
            t.Abort();
        }

        private void SplashScreen() => Application.Run(new Splash());

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            trackBarValue1.Text = trackBar1.Value.ToString();
            trackBarValue2.Text = trackBar3.Value.ToString();
            trackBarValue3.Text = trackBar2.Value.ToString();
            trackBarValue4.Text = trackBar4.Value.ToString();

            trackBar1.Visible = false;
            trackBar2.Visible = false;
            trackBar3.Visible = false;
            trackBar4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;

            trackBarValue1.Visible = false;
            trackBarValue2.Visible = false;
            trackBarValue3.Visible = false;
            trackBarValue4.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
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

        private void btnMin_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Data.imageLocation = ofd.FileName;
                selectedPic.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.imageLocation != "")
            {

                if(checkBox1.Checked)
                {
                    Data.threshold = trackBar1.Value;
                    Data.resolution = trackBar3.Value;
                    Data.compression = trackBar2.Value;
                    Data.accuracy = trackBar4.Value;
                }
                else
                {
                    Data.threshold = 50;
                    Data.resolution = 600;
                    Data.compression = 50;
                    Data.accuracy = 4;
                }
                

                // Rozpoczecie procesu
                List<string> outputColors = new List<string>();
                Bitmap holder = new Bitmap(Data.imageLocation);
                Bitmap map = new Bitmap(holder, Data.resolution, Data.resolution); //Tutaj bede jedne z paramatrow
                Alchemy.analyze(Pixelate.convert(map, new Rectangle(0, 0, map.Width, map.Height), 50), outputColors);

                for (int i = 0; i < 7; i++)
                {
                    Data.colors[i] = outputColors[i];
                }

                this.Hide();
                outputWindow outputWin = new outputWindow();
                outputWin.ShowDialog();
                this.Close(); 
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarValue1.Text = trackBar1.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            trackBarValue2.Text = trackBar3.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBarValue3.Text = trackBar2.Value.ToString();
        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            trackBarValue4.Text = trackBar4.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                trackBar4.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;

                trackBarValue1.Visible = true;
                trackBarValue2.Visible = true;
                trackBarValue3.Visible = true;
                trackBarValue4.Visible = true;
            }
            else
            {
                trackBar1.Visible = false;
                trackBar2.Visible = false;
                trackBar3.Visible = false;
                trackBar4.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;

                trackBarValue1.Visible = false;
                trackBarValue2.Visible = false;
                trackBarValue3.Visible = false;
                trackBarValue4.Visible = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
