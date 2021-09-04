using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        public static bool RecBinarySearch(int[] arr,int l,int r,int num)
        {
            if (arr.Length == 0|| l>=r)
                return false;
            int mid = (r + l) / 2;
            if (arr[mid] == num)
                return true;
            else
                return RecBinarySearch(arr, l, mid, num) || RecBinarySearch(arr, mid + 1, r, num);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 4, 5, 6, 7, 8, 7, 6, 5, 4, 7 };
            Console.WriteLine("Insert number for search in the array");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("the answer is: {0}",RecBinarySearch(arr,0,arr.Length,num));
            Console.ReadLine();
        }
    }
}
