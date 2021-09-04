using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppingNumbers
{
    class Program
    {
        public static void BFS(int n,int m, int num)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(num);
            while(q.Count!=0)
            {
                int stepNumber = q.Dequeue();
                if(stepNumber>=n && stepNumber <=m)
                    Console.WriteLine(stepNumber+" ");
                if (stepNumber < n || stepNumber == 0 || stepNumber > m)
                    continue;
                int lastD = stepNumber % 10;
                int num1 = stepNumber * 10 + (lastD + 1);
                int num2 = stepNumber * 10 + (lastD - 1);
                if (lastD == 0)
                    q.Enqueue(num1);
                else if (lastD == 9)
                    q.Enqueue(num2);
                else
                {
                    q.Enqueue(num1);
                    q.Enqueue(num2);
                }
            }
        }
        public static void PrintStepsNumbers(int n,int m)
        {
            for (int i = 0; i < 9; i++)
            {
                BFS(n, m, i);
            }
        }
        static void Main(string[] args)
        {
            int n = 2, m = 21;
            PrintStepsNumbers(n, m);
            Console.ReadLine();
        }
    }
}
