using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product P1 = new Product();
            P1.title = "iPhone 14";
            P1.description = "The newest and fastest phone in the market";
            P1.price= 30000M;
            P1.quantity = 1;
            P1.ID = 1234;

            Product P2 = new Product();
            P2.title = "Nintendo Switch";
            P2.description = "Play and have fun with your friends";
            P2.price = 10000M;
            P2.quantity = 7;
            P2.ID = 3214;

            Order O1 = new Order();
            O1.addProduct(P1);
            O1.addProduct(P2);


            Console.WriteLine(O1.total);
            O1.totalP();
            Console.WriteLine(O1.totalPrice);
        }
    }
}
