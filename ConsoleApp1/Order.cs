using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        public string shipping { get; set; }

        public List<Product> products;
        public decimal total => products.Count;
        public decimal totalPrice { get; set; }
        public Order()
        {
            this.products = new List<Product>();
        }

        public void addProduct(Product product)
        {
            int x = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ID.Equals(product.ID))
                {
                    x += 1;
                    products[i].quantity += product.quantity;
                }

            }
            if (x == 0)
            {
                this.products.Add(product);
            }
        }
        public void totalP()
        {
            for (int i = 0; i < products.Count; i++)
            {
                for (int j = 0; j < products[i].quantity; j++)
                {
                    totalPrice += products[i].price - (products[i].price * products[i].discount / 100);
                }
            }
        }
    }
}



