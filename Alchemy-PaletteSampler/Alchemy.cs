using System.Collections.Generic;
using System.Drawing;

namespace Alchemy_PaletteSampler
{
    class Alchemy
    {
        public static void analyze(Bitmap map, List<Tint> inputTab, string[] outputTab)
        {
            bool control;
            // false = nie ma jeszcze tego koloru w liscie
            // true = ten kolor juz jest w liscie

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
            Sort.colorBubbleSort(inputTab);

            /*
            for (int o = inputTab.Count - 1, p = 0; o > inputTab.Count - 5; o--, p++)
            {
                outputTab[p] = inputTab[o].printColor();
            }
            */

            /*
            Filter colorFilter = new Filter(50);
            outputTab[0] = inputTab[inputTab.Count-1].printColor();
            int currentCheck = inputTab.Count - 1;
            bool isGood = true;
            int outputTabIndex = 1;
            while(outputTab.Length < 4)
            {
                isGood = true;
                for(int i=0; i< outputTab.Length; i++)
                {
                    if (colorFilter.different(hextoColor(outputTab[i]), hextoColor(inputTab[currentCheck].printColor())))
                    {
                        isGood = false; 
                    }
                }

                if(isGood)
                {
                    outputTab[outputTabIndex] = inputTab[currentCheck].printColor();
                    outputTabIndex++;
                }

                currentCheck--;
            }*/
            

            //Remember to resize!!!



            Filter filter = new Filter(200); //Tworzymy nowy filtr z threshold 50!
            int currentCheck = 1;
            int outputTabIndex = 1;
            bool isGood = true;

            outputTab[0] = inputTab[0].printColor();

            while(outputTabIndex < 4)
            {
                isGood = true;
                for(int j=0; j<outputTab.Length; j++)
                {
                    if(filter.different(hextoColor(outputTab[j]), hextoColor(inputTab[currentCheck].printColor())))
                    {
                        isGood = false;
                    }
                }

                if(isGood)
                {
                    outputTab[outputTabIndex] = inputTab[currentCheck].printColor();

                    outputTabIndex++;
                    currentCheck++;
                }
                else
                {
                    currentCheck++;
                }
            }


        }


        private static string toHex(Color a)
        {
            string hex = a.R.ToString("X2") + a.G.ToString("X2") + a.B.ToString("X2");
            return "#" + hex;
        }

        private static Color hextoColor(string input)
        {
            return ColorTranslator.FromHtml(input);
        }
    }
}
