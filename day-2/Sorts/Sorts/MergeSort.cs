using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class MergeSort
    {
        public static void Merge(int[] arr, int r, int l, int m)
        {
            int n1 = m - (l);
            int n2 = r - m;
            int[] left = new int[n1];
            int[] right = new int[n2];
            int i, j;
            for ( i = 0; i < left.Length; i++)
            {
                left[i] = arr[l + i];
            }
            for ( j = 0; j < right.Length; j++)
            {
                right[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = arr[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
            
        }
        public static void Sort(int[] arr, int l, int r)
        {
            int mid;
            if (l < r)
            {
                mid = l + (r - l) / 2;
                Sort(arr, l, mid);
                Sort(arr, mid + 1, r);
                Merge(arr, r, l, mid);
            }
        }
    }
}
