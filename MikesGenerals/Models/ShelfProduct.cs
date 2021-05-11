using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeGenerals.BusinessLogic.Models
{
    public class ShelfProduct
    {
        private Product Product;
        private int Quantity;
        
        public ShelfProduct(Product product, int initialQuantity)
        {
            Product = product;
            Quantity = initialQuantity;
        }
        public int GetId()
        {
            return Product.GetId();
        }
        public string GetName()
        {
            return Product.GetName();
        }

        public void SetName(string name)
        {
            Product.SetName(name);
        }

        public void SetPrice(decimal price)
        {
            Product.SetPrice(price);
        }

        public decimal GetPrice()
        {
            return Product.GetPrice();
        }

    }
}
