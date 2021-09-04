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
        private List<int>[] adjacents;
        Graph(int vertex)
        {
            this.countOfVer = vertex;
            adjacents = new List<int>[vertex];
            for(int i=0;i<adjacents.Length;i++)
            {
                adjacents[i] = new List<int>();
            }
        }
    }
}
