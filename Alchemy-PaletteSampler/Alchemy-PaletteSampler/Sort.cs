using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy_PaletteSampler
{
    class Sort
    {
        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static void colorBubbleSort(List<Tint> tab)
        {
            for(int i=0; i < tab.Count - 1; i++)
            {
                for(int j=0; j < tab.Count - i - 1; j++)
                {
                    if(tab[j].getAmount() > tab[j+1].getAmount())
                    {
                        //Swap<int>(tab[j], tab[j+1]);
                    }
                }
            }
        }

        
    }
}
