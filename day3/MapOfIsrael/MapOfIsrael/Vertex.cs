using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOfIsrael
{
    class Vertex<T>
    {
        private T value { get; set; }
        private int distance;
        private List<Vertex<T>> neigborsVertex { get; set; }


        public Vertex(T value, int distance)
        {
            this.value = value;
            this.neigborsVertex = new List<Vertex<T>>();
            this.distance = distance;
        }
        public void AddNeighbor(T value, int dist)
        {
            this.neigborsVertex.Add(new Vertex<T>(value, dist));
        }

        public T GetValue()
        {
            return this.value;
        }
        public int GetDist()
        {
            return this.distance;
        }


    }
}
