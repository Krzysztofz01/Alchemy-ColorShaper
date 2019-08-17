using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy_ColorShaper2
{
    class Processing
    {
        //Alchemy class contains default analyzing algorithm

        public static void legacy(Bitmap map, List<string> outputTab, int threshold, int resolution, int compression, int accuracy)
        {
            List<Tint> inputTab = new List<Tint>();
            bool control;
            // false = this color isn't on the list
            // true = this color is already on the list

            //Checking all pixels in a loop row by row
            for (int y = 0; y < map.Height; y += accuracy)
            {
                for (int x = 0; x < map.Width; x += accuracy)
                {
                    control = false;
                    if (inputTab.Count == 0)
                    {
                        inputTab.Add(new Tint(toHex(map.GetPixel(x, y))));
                    }
                    else
                    {
                        for (int i = 0; i < inputTab.Count; i++)
                        {
                            if (toHex(map.GetPixel(x, y)) == inputTab[i].getColor())
                            {
                                control = true;
                                inputTab[i].add();
                            }
                        }

                        if (!control)
                        {
                            inputTab.Add(new Tint(toHex(map.GetPixel(x, y))));
                        }
                    }
                }
            }

            //Sorting colors by number of occurences
            Sort.colorBubbleSort(inputTab);

            //inputTab = inputTab.OrderBy(x => x.getAmount()).ToList();
            //Linq okazał się wolniejszy

            //Removing colors that are too similar to each other
            Filter filter = new Filter(threshold);
            int inputTabIndex = inputTab.Count - 2;
            bool isGood;

            outputTab.Add(inputTab[inputTab.Count - 1].getColor());
            while (outputTab.Count < 7)
            {
                isGood = true;

                for (int y = 0; y < outputTab.Count; y++)
                {
                    if (filter.different(hextoColor(outputTab[y]), hextoColor(inputTab[inputTabIndex].getColor())))
                        isGood = false;
                }

                if (isGood)
                {
                    outputTab.Add(inputTab[inputTabIndex].getColor());
                    inputTabIndex--;
                }
                else
                {
                    inputTabIndex--;
                }
            }

            /// DEBUG ///
            for (int m = 0; m < outputTab.Count; m++)
            {
                Console.Out.WriteLine(outputTab[m]);
            }
        }

        private static string toHex(Color a) => "#" + a.R.ToString("X2") + a.G.ToString("X2") + a.B.ToString("X2");

        //Hex string to Color struct conversion method
        public static Color hextoColor(string input) => ColorTranslator.FromHtml(input);
    }
}



