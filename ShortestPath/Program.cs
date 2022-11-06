using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node NodeA = new Node();
            NodeA.Vertex = "A";

            Node NodeB = new Node();
            NodeB.Vertex = "B";

            Node NodeC = new Node();
            NodeC.Vertex = "C";

            Node NodeD = new Node();
            NodeD.Vertex = "D";

            //A to B and C
            NodeA.Edges.Add(new Node.Edge() { Node = NodeB, Weight = 5 });
            NodeA.Edges.Add(new Node.Edge() { Node = NodeC, Weight = 10 });
            NodeA.Edges.Add(new Node.Edge() { Node = NodeD, Weight = 8 });
            //B to A, C and D
            NodeB.Edges.Add(new Node.Edge() { Node = NodeA, Weight = 5 });
            NodeB.Edges.Add(new Node.Edge() { Node = NodeC, Weight = 10 });
            NodeB.Edges.Add(new Node.Edge() { Node = NodeD, Weight = 7 });

            //C to A, B and D
            NodeC.Edges.Add(new Node.Edge() { Node = NodeA, Weight = 10 });
            NodeC.Edges.Add(new Node.Edge() { Node = NodeB, Weight = 6 });
            NodeC.Edges.Add(new Node.Edge() { Node = NodeD, Weight = 14 });

            //D to B and C
            NodeD.Edges.Add(new Node.Edge() { Node = NodeA, Weight = 8 });
            NodeD.Edges.Add(new Node.Edge() { Node = NodeB, Weight = 7 });
            NodeD.Edges.Add(new Node.Edge() { Node = NodeC, Weight = 14 });

            List<Node> graph= new List<Node> { NodeA, NodeB, NodeC, NodeD };

            var algorithm = new Path.ShortestP(graph, 4, NodeA);
            algorithm.Run();
            Console.WriteLine(algorithm.PrintPaths);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
