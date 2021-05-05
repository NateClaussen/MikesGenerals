using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGenerals
{
    public class Product
    {
        private readonly int Id;
        private string Name;
        private decimal Price;

        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
