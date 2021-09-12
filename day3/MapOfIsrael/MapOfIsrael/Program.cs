using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapOfIsrael
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph mapOfIsrael = new Graph();
            mapOfIsrael.AddCity("Nehariya");
            mapOfIsrael.AddCity("Tiberias");
            mapOfIsrael.AddCity("Kiryat Shemona");
            mapOfIsrael.AddCity("Haifa");
            mapOfIsrael.AddCity("Natharath");
            mapOfIsrael.AddCity("Netanya");
            mapOfIsrael.AddCity("Tel Aviv");
            mapOfIsrael.AddCity("Jerusalem");
            mapOfIsrael.AddCity("Rishon");
            mapOfIsrael.AddCity("Bet Shemesh");
            mapOfIsrael.AddCity("Ashkelon");
            mapOfIsrael.AddCity("Beer Sheva");
            mapOfIsrael.AddCity("Dimona");
            mapOfIsrael.AddCity("Mizpe Ramon");
            mapOfIsrael.AddCity("Eilat");
            // add the neighbors to the cities
            mapOfIsrael.AddNeighbor("Eilat", "Mizpe Ramon", 120);
            mapOfIsrael.AddNeighbor("Eilat", "Tel Aviv", 280);
            mapOfIsrael.AddNeighbor("Mizpe Ramon", "Beer Sheva", 68);
            mapOfIsrael.AddNeighbor("Dimona", "Beer Sheva", 30);
            mapOfIsrael.AddNeighbor("Dimona", "Jerusalem", 75);
            mapOfIsrael.AddNeighbor("Beer Sheva", "Jerusalem", 65);
            mapOfIsrael.AddNeighbor("Beer Sheva", "Bet Shemesh", 55);
            mapOfIsrael.AddNeighbor("Beer Sheva", "Ashkelon", 48);
            mapOfIsrael.AddNeighbor("Bet Shemesh", "Rishon", 30);
            mapOfIsrael.AddNeighbor("Nehariya", "Kiryat Shemona", 55);
            mapOfIsrael.AddNeighbor("Nehariya", "Haifa", 25);
            mapOfIsrael.AddNeighbor("Nehariya", "Jerusalem", 135);
            mapOfIsrael.AddNeighbor("Tiberias", "Kiryat Shemona", 45);
            mapOfIsrael.AddNeighbor("Tiberias", "Haifa", 50);
            mapOfIsrael.AddNeighbor("Tiberias", "Natharath", 26);
            mapOfIsrael.AddNeighbor("Haifa", "Natharath", 35);
            mapOfIsrael.AddNeighbor("Haifa", "Netanya", 52);
            mapOfIsrael.AddNeighbor("Netanya", "Natharath", 57);
            mapOfIsrael.AddNeighbor("Netanya", "Tel Aviv", 31);
            mapOfIsrael.AddNeighbor("Tel Aviv", "Rishon", 15);
            mapOfIsrael.AddNeighbor("Tel Aviv", "Beer Sheva", 90);
            mapOfIsrael.AddNeighbor("Rishon", "Jerusalem", 34);
            mapOfIsrael.AddNeighbor("Rishon", "Ashkelon", 40);
        }
    }
}
