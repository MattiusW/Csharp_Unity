using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Bubble
    {
        public static int[] BubbleSort(int[] tab)
        { 
            for (int i = 1; i < tab.Length; i++ )
            {
                for (int j = 0; j < tab.Length; j++)
                {
                    if (tab[j] > tab[i]) 
                    {
                        int temp = tab[j];
                        tab[j] = tab[i];
                        tab[i] = temp;
                    }
                }
            }
            return tab;
        }
    }
}
