using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topThreeRepetedInArray
{
    class Pair
    {
        private int first;
        private int second;
        public int GetFirst()
        {
            return this.first;
        }
        public void SetFirst(int newFirst)
        {
            this.first = newFirst;
        }
        public int GetSecond()
        {
            return this.second;
        }
        public void SetSecond(int newSecond)
        {
            this.second = newSecond;
        }
    }
    class Program
    {
        public static void GetRepeatNumbers(int[]arr,int n)
        {
            if(n<3)
            {
                Console.WriteLine("invalid!! please enter correct input!!!");
                return;
            }
            Dictionary<int, int> freq = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if(freq.ContainsKey(arr[i]))
                {
                    freq[arr[i]]++;
                }
                else
                {
                    freq[arr[i]] = 1;
                }
            }
            Pair x = new Pair();
            Pair y = new Pair();
            Pair z = new Pair();
            x.SetFirst(int.MinValue);
            y.SetFirst(int.MinValue);
            z.SetFirst(int.MinValue);
            foreach(var item in freq)
            {
                if(item.Value>x.GetFirst())
                {
                    z.SetFirst(y.GetFirst());
                    z.SetSecond(y.GetSecond());
                    y.SetFirst(x.GetFirst());
                    y.SetSecond(x.GetSecond());
                    x.SetFirst(item.Value);
                    x.SetSecond(item.Key);
                }
                else if (item.Value > y.GetFirst())
                {
                    z.SetFirst(y.GetFirst());
                    z.SetSecond(y.GetSecond());
                    y.SetFirst(item.Value);
                    y.SetSecond(item.Key);
                }
                else if (item.Value > z.GetFirst())
                {
                    z.SetFirst(item.Value);
                    z.SetSecond(item.Key);
                }
            }
            Console.WriteLine("Thw first maxsimum is: {0}",x.GetSecond());
            Console.WriteLine("Thw second maxsimum is: {0}", y.GetSecond());
            Console.WriteLine("Thw third maxsimum is: {0}", z.GetSecond());
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 1, 21, 2,2,2,2,2,2,4,3,4,3,3,4,4,};
            int length = arr.Length;
            GetRepeatNumbers(arr, length);


        }
    }
}
