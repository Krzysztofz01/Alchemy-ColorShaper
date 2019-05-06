using System.Drawing;

namespace Alchemy_ColorShaper
{
    class Export
    {
        public static void exportAsImage()
        {
            Bitmap image = new Bitmap(Data.imageLocation);

            int boxWidth = image.Width / 5;
            int boxHeight = image.Height / 8;
            int margin = boxHeight / 9;
            int center = (image.Width / 2) - (boxWidth / 2);
            int template = margin;

            for(int i=0; i<7; i++)
            {
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    using (SolidBrush brush = new SolidBrush(Alchemy.hextoColor(Data.colors[i])))
                    {
                        graphics.FillRectangle(brush, center, template, boxWidth, boxHeight);

                        template += margin + boxHeight;
                    }
                }
            }
            image.Save("Exported Palette.bmp");
            System.Windows.Forms.MessageBox.Show("Image has been exported!");

        }
    }
}