using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Alchemy_PaletteSampler
{
    public partial class Form1 : Form
    {
        //private string[] outputColors = new string[4];
        private List<string> outputColors = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                progressBar.Visible = true;

                List<Tint> colorTab = new List<Tint>();
                Bitmap map = new Bitmap(pictureBox.Image, 600, 600);

                Alchemy.analyze(Pixelate.convert(map, new Rectangle(0, 0, map.Width, map.Height), 50), colorTab, outputColors);

                // Metoda pikselizacji 
                //pictureBox.Image = Pixelate.convert(map, new Rectangle(0, 0, map.Width, map.Height), 50);

                paintPanels();

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void paintPanels()
        {
            progressBar.Visible = false;

            colorPanel1.Visible = true;
            colorPanel2.Visible = true;
            colorPanel3.Visible = true;
            colorPanel4.Visible = true;

            colorPanel1.BackColor = ColorTranslator.FromHtml(outputColors[0]);
            colorPanel2.BackColor = ColorTranslator.FromHtml(outputColors[1]);
            colorPanel3.BackColor = ColorTranslator.FromHtml(outputColors[2]);
            colorPanel4.BackColor = ColorTranslator.FromHtml(outputColors[3]);

            colorText1.Text = outputColors[0];
            colorText2.Text = outputColors[1];
            colorText3.Text = outputColors[2];
            colorText4.Text = outputColors[3];
        }
    }
}
