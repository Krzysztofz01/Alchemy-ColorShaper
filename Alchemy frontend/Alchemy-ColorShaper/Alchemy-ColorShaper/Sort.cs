using Alchemy_ColorShaper;
using System.Collections.Generic;

namespace Alchemy_PaletteSampler
{
    class Sort
    {
        private static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        public static void colorBubbleSort(List<Tint> tab)
        {
            for (int i = 0; i < tab.Count - 1; i++)
            {
                for (int j = 0; j < tab.Count - i - 1; j++)
                {
                    if (tab[j].getAmount() > tab[j + 1].getAmount())
                    {
                        Swap(tab, j, j + 1);
                    }
                }
            }
        }

        //https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-7.php

    }
}