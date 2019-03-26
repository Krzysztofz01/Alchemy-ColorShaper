using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Alchemy_PaletteSampler
{
    public partial class Form1 : Form
    {
        private string[] outputColors = new string[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                progressBar.Visible = true;

                if (progressBar.Visible)
                {
                    analyze();
                }
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

        private void analyze()
        {
            List<Tint> colorTab = new List<Tint>();
            bool control;
            // false = nie ma jeszcze tego koloru w liscie
            // true = ten kolor juz jest w liscie

            Bitmap map = new Bitmap(pictureBox.Image);

            for(int y=0; y<map.Height; y++)
            {
                for(int x=0; x<map.Width; x++)
                {
                    control = false;
                    if(colorTab.Count == 0)
                    {
                        colorTab.Add(new Tint(Alchemy.toHex(map.GetPixel(x, y))));
                    }
                    else
                    {
                        for(int i=0; i < colorTab.Count; i++)
                        {
                            if(Alchemy.toHex(map.GetPixel(x, y)) == colorTab[i].printColor())
                            {
                                control = true;
                                colorTab[i].add();
                            }
                        }

                        if(!control)
                        {
                            colorTab.Add(new Tint(Alchemy.toHex(map.GetPixel(x, y))));
                        }
                    }
                }
            }

            Sort.colorBubbleSort(colorTab);

            //Możliwe ze to nie działa przez to
            for(int i=colorTab.Count - 1, j=0; i>colorTab.Count - 5; i--, j++)
            {
                Console.Out.WriteLine(colorTab[i].printColor());
                Console.Out.WriteLine(colorTab[i].getAmount());
                Console.Out.WriteLine("===========================");

                outputColors[j] = colorTab[i].printColor();  
            }

            paintPanels();
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
