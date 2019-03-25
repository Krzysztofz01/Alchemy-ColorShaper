using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchemy_PaletteSampler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            analyze();
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
            bool control = false;
            // false = nie ma jeszcze tego koloru w liscie
            // true = ten kolor juz jest w liscie


            Bitmap map = new Bitmap(pictureBox.Image);

            for(int y=0; y<map.Height; y++)
            {
                for(int x=0; x<map.Width; x++)
                {
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
                            }
                        }

                        if(!control)
                        {
                            colorTab.Add(new Tint(Alchemy.toHex(map.GetPixel(x, y))));
                        }
                    }
                }
            }
        }
    }
}
