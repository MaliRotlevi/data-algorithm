using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class BubbleSort
    {
        public static int[] BubleSort(int[] arr, int length)
        {
            int num = 0;
            bool swap = true;
            for (int i = 0; i < length - 1; i++)
            {
                if (swap == false)
                    return arr;

                swap = false;
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap = true;
                        num = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = num;
                    }
                }
            }
            return arr;
        }
    }
}
