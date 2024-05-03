using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAlgo
{
    internal class SortArray<T>
    {
            public void BubbleSort(T []? arra)
            {
                for (int i = 0; i < arra.Length - 1; i++)
                {
                    for (int j = 0; j < arra.Length - i - 1; j++)
                    {
                        if (((IComparable)arra[j]).CompareTo(arra[j + 1]) > 0)
                        {
                            swap(arra, j);
                        }
                    }
                }
            }


            public void swap(T[] arra, int i)
            {
                T temp = arra[i];
                arra[i] = arra[i + 1];
                arra[i + 1] = temp;
            }

        
    }
}
