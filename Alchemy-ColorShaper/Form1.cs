using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchemy_ColorShaper
{
    public partial class Form1 : Form
    {
        string picDir = "";
        Color mostAv1, mostAv2, mostAv3;

        public Form1()
        {
            InitializeComponent();
        }

        public void colorOut()
        {
            colorPanel1.BackColor = mostAv1;
            colorPanel2.BackColor = mostAv2;
            colorPanel3.BackColor = mostAv3;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPic = new OpenFileDialog();
            openPic.Filter = "JPG|*.jpg";

            if(openPic.ShowDialog()==DialogResult.OK)
            {
                picDir = openPic.FileName.ToString();
                picPanel.ImageLocation = picDir;
            }
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            if (picDir != "")
            {
                Bitmap map = new Bitmap(picPanel.Image);

                List<Color> averageColor = new List<Color>();
                List<Color> colorBuffer = new List<Color>();

                for (int i = 0; i < map.Width; i++)
                {
                    for (int j = 0; j < map.Height; j++)
                    {
                        colorBuffer.Add(map.GetPixel(i, j));
                    }
                    averageColor.Add(Sort.MostCommon(colorBuffer));

                    //Pierwszy kolor
                    mostAv1 = Sort.MostCommon(averageColor);

                    for (int x = 0; x < averageColor.Count; i++)
                    {
                        if (averageColor[x] == mostAv1)
                        {
                            averageColor.Remove(mostAv1);
                        }
                    }

                    //Drugi kolor
                    if (averageColor.Count != 0)
                    {
                        mostAv2 = Sort.MostCommon(averageColor);

                        for (int x = 0; x < averageColor.Count; i++)
                        {
                            if (averageColor[x] == mostAv2)
                            {
                                averageColor.Remove(mostAv2);
                            }
                        }
                    }

                    //Trzeci kolor
                    if (averageColor.Count != 0)
                    {
                        mostAv3 = Sort.MostCommon(averageColor);

                        for (int x = 0; x < averageColor.Count; i++)
                        {
                            if (averageColor[x] == mostAv3)
                            {
                                averageColor.Remove(mostAv3);
                            }
                        }
                    }
                }

                colorOut();
            }

        }


    }

    public static class Sort
    {
        public static T MostCommon<T>(this IEnumerable<T> list)
        {
            return list.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
        }
    };
}
