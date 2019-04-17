using Alchemy_PaletteSampler;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Alchemy_ColorShaper
{
    class Alchemy
    { 
        //Alchemy class contains default analyzing algorithm

        public static void analyze(Bitmap map, List<string> outputTab)
        {
            List<Tint> inputTab = new List<Tint>();
            bool control;
            // false = this color isn't on the list
            // true = this color is already on the list

            //Checking all pixels in a loop row by row
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    control = false;
                    if (inputTab.Count == 0)
                    {
                        inputTab.Add(new Tint(Alchemy.toHex(map.GetPixel(x, y))));
                    }
                    else
                    {
                        for (int i = 0; i < inputTab.Count; i++)
                        {
                            if (Alchemy.toHex(map.GetPixel(x, y)) == inputTab[i].printColor())
                            {
                                control = true;
                                inputTab[i].add();
                            }
                        }

                        if (!control)
                        {
                            inputTab.Add(new Tint(Alchemy.toHex(map.GetPixel(x, y))));
                        }
                    }
                }
            }

            //Sorting colors by number of occurences
            Sort.colorBubbleSort(inputTab);

            //Removing colors that are too similar to each other
            Filter filter = new Filter(Data.threshold); 
            int inputTabIndex = inputTab.Count - 2;
            bool isGood;

            outputTab.Add(inputTab[inputTab.Count - 1].printColor());
            while (outputTab.Count < 7)
            {
                isGood = true;

                for (int y = 0; y < outputTab.Count; y++)
                {
                    if (filter.different(hextoColor(outputTab[y]), hextoColor(inputTab[inputTabIndex].printColor())))
                        isGood = false;
                }

                if (isGood)
                {
                    outputTab.Add(inputTab[inputTabIndex].printColor());
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

        //Color struct to Hex string conversion method
        private static string toHex(Color a)
        {
            string hex = a.R.ToString("X2") + a.G.ToString("X2") + a.B.ToString("X2");
            return "#" + hex;
        }

        //Hex string to Color struct conversion method
        public static Color hextoColor(string input)
        {
            return ColorTranslator.FromHtml(input);
        }
    }
}
