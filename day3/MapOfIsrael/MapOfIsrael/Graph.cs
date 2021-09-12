using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOfIsrael
{
    class Graph
    {
        private Dictionary<string, Vertex<string>> cities;
        public Graph()
        {
            this.cities = new Dictionary<string, Vertex<string>>();
        }
        public void AddCity(string city)
        {
            cities.Add(city, new Vertex<string>(city, 0));
        }
        public void AddNeighbor(string city, string neighbor, int dist)
        {
            cities[city].AddNeighbor(neighbor, dist);
            cities[neighbor].AddNeighbor(city, dist);
        }
    }
}
