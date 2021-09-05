using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topological_Sort
{
    class Program
    { 
        public static int[] TopologicalSort(int n,int[,]adjacent)
        {
            int ver,c=0;
            Queue<int> q = new Queue<int>();
            bool[] visited = new bool[n];
            int[] degree = new int[n];
            int[] topologicalSort = new int[n];
            //init the arrays to the default option
            for(int i=0;i<n;i++)
            {
                visited[i] = false;
                degree[i] = 0;
            }
            //init the dgree's array
            for(int i=0;i<n;i++)
                for (int j = 0; j < n; j++)
                    if (adjacent[i,j] == 1)
                        degree[j]++;
            //looking for the beginning vertex
            for(int i=0;i<n;i++)
            {
                if (degree[i] == 0) { 
                    q.Enqueue(i);
                    visited[i] = true;
                }
            }
            while(q.Count!=0)
            {
                ver = q.Dequeue();
                topologicalSort[c]=ver;
                c++;
                for (int i = 0; i < n; i++)
                {
                    if (adjacent[ver,i] == 1 && visited[i]==false)
                    {
                        degree[i]--;
                        if(degree[i]==0)
                        {
                            visited[i] = true;
                            q.Enqueue(i);
                        }
                    }
                }
            }
            return topologicalSort;    
        }
        public static void PrintArray(int[] arr,int length)
        {
            for (int i = 0; i < length; i++)
            {
     
                Console.Write(arr[i] + "  ");
                
                
            }
        }
    
        static void Main(string[] args)
        {
            int[,] adjacent = new int[,] { { 0, 1, 0, 1, 0, 0 },
                                         { 0, 0, 1, 1, 0, 0 },
                                         { 0, 0, 0, 1, 1, 1 },
                                         { 0, 0, 0, 0, 1, 1 },
                                         { 0, 0, 0, 0, 0, 1 },
                                         { 0, 0, 0, 0, 0, 0 }};
            int[] Ttree = TopologicalSort(6,adjacent);
            PrintArray(Ttree,Ttree.Length);
            Console.ReadLine();
        }
    }
}
