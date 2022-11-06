using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Graph obj = new Graph(4);

           
            obj.addEdge(0, 1);
            obj.addEdge(0, 2);
            obj.addEdge(1, 2);
            obj.addEdge(2, 3);
    
            Console.WriteLine("\n original matrix");
            obj.displayAdjacencyMatrix();

            obj.addVertex();

           
            obj.addEdge(4, 1);
            obj.addEdge(4, 3);
            Console.WriteLine("\n Matrix with the vertex added");
            
            obj.displayAdjacencyMatrix();

            Console.WriteLine("\n Matrix with the vertex deleted");
           
            obj.removeVertex(1);
           
            obj.displayAdjacencyMatrix();

            Console.WriteLine("\nBFS");
            obj.BFS(1);
          
            Console.WriteLine("\nDFS");
            obj.DFS(1);
            Console.ReadKey();


        
        }



    }
}

