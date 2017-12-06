using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class InsertionSort : Strategy
    {
        public override int[] Sort(int[] array, int size)
        {
            int key;

            for (int i = 1; i < size; i++)
            {
                key = array[i];
                int j = i - 1;

                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }

            return array;
        }
    }
}
