using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class AdjacencyMatrix
    {
        private int[,] mat;
        private int length;
        //a c'tor that init reset the matrix
        public AdjacencyMatrix(int length)
        {

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    mat[i, j] = 0;
                }
            }
        }
        public void AddEdge(int i,int j)
        {
            this.mat[i, j] = 1;
        }
        public void RemoveEdge(int i, int j)
        {
            this.mat[i, j] = 0;
        }
        public int GetLength()
        {
            return this.length;
        }
    }
}
