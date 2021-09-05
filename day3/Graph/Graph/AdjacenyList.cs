using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacenyList
    {
        private List<int>[] list;
        int length;
        public AdjacenyList(int length)
        {
            list = new List<int>[length];
            for (int i = 0; i < length; i++)
            {
                list[i] = new List<int>();
            }
        }
        public void AddEdge(int i,int j)
        {
            list[i].Add(j);
        }
        public void RemoveEdge(int i, int j)
        {
            list[i].Remove(j);
        }
        public int GetLength()
        {
            return this.length;
        }
    }
}
