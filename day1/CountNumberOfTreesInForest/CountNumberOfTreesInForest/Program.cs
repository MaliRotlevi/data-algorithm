using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberOfTreesInForest
{
    class Graph
    {
        private int countOfVer;
        private List<int>[] adjacent;
        public Graph(int newCountOfVer)
        {
            this.countOfVer = newCountOfVer;
            adjacent = new List<int>[newCountOfVer];
            for(int i=0; i<adjacent.Length;i++)
            {
                adjacent[i] = new List<int>();
            }
        }
        public void AddEdge(int v,int w)
        {
            adjacent[v].Add(w);
        }
        public void DFS(int v,bool[] visited)
        {
            int n;
            visited[v] = true;
            foreach(int i in adjacent[v])
            {
                n = i;
                if(visited[n]==false)
                {
                    DFS(n, visited);
                }
            }
        }
        public int CountNumberOfTrees()
        {
            bool[] visited = new bool[countOfVer];
            int c = 0;
            for (int i = 0; i < countOfVer; i++)
            {
                if(visited[i]==false)
                {
                    DFS(i, visited);
                    c++;
                }
            }
            return c;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Graph g = new Graph(10);
            g.AddEdge(1, 2);
            g.AddEdge(3, 2);
            g.AddEdge(5, 6);
            Console.WriteLine("count number of trees in forest is: "+g.CountNumberOfTrees());
            Console.ReadLine();
        }
    }
}
