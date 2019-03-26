using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for(int i=0; i < tab.Count - 1; i++)
            {
                for(int j=0; j < tab.Count - i - 1; j++)
                {
                    if(tab[j].getAmount() > tab[j+1].getAmount())
                    {
                        Swap(tab, j, j + 1);
                    }
                }
            }
        }

        
    }
}
