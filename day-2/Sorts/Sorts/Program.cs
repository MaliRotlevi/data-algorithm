using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    { 
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}, ", arr[i]);

            }
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            
            
                int[] arr = new int[] { 5, 6, 1, 8, 4, 9, 19 };
                int[] brr = new int[] { 5, 6, 1, 8, 4, 9, 19 };
                arr = BubbleSort.BubleSort(arr, arr.Length);
                MergeSort.Sort(brr, 0, brr.Length-1);
                PrintArray(arr);
                PrintArray(brr);
                Console.ReadLine();
            
        }
    }
}
