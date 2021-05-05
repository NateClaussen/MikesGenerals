using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGenerals
{
    public class ShoppingCart
    {
        private int CustomerId;
        private List<Product> Items;

        public ShoppingCart(Customer customer)
        {
            CustomerId = customer.GetId();
        }

        public int GetCustomerId()
        {
            return CustomerId;
        }

        public void AddProduct(Product product, int count)
        {
            for (var i = 0; i < count; i++)
            {
                Items.Add(product);
            }
        }

        public void RemoveProduct(Product product, int count)
        {
            for(var i = 0; i < count; i++)
            {
                Items.Remove(product);
            }
        }

        public decimal GetTotal()
        {
            decimal runningTotal = 0;
            foreach(var item in Items)
            {
                runningTotal += item.GetPrice();
            }
            return runningTotal;
        }
    }
}
