using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class BFS
    {
        public void Bfs(int s,AdjacenyList list)
        {

            bool[] visited = new bool[list.GetLength()];
            for (int i = 0; i <list.GetLength(); i++)
                visited[i] = false;         
            LinkedList<int> queue = new LinkedList<int>();
            visited[s] = true;
            queue.AddLast(s);
            while (queue.Any())
            {           
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();
                List<int> llist = list.GetAdjacentList()[s];
                foreach (var val in llist)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
    }
}
