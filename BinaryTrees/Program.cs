using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(12);
            binaryTree.Add(1);
            binaryTree.Add(6);
            binaryTree.Add(9);
            binaryTree.Add(13);
            binaryTree.Add(0);
            binaryTree.Add(2);
            binaryTree.Add(4);
            binaryTree.Add(8);
            binaryTree.Add(11);
            binaryTree.Add(15);
            binaryTree.Add(5);
            binaryTree.Add(10);
            binaryTree.Add(14);

            //Node node = binaryTree.Find(5);
           
            Console.WriteLine("PreOrder:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();
            binaryTree.graficar();


           

            Console.ReadLine();
        }
    }
}
