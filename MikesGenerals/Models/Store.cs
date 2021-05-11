using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeGenerals.BusinessLogic.Models
{
    public class Store
    {
        private int Id;
        private string Name;
        private List<Product> Products;
        private List<ShelfProduct> ShelfProducts;

        

        public void AddProduct(Product product/*, int amount*/)
        {
            /*
            * This is what I would probably do if I were doing this project, but not what is asked
             * for in the assignment, so I commented it out.
            var existing = ShelfProducts.Where(p => p.GetId() == product.GetId());
            if(!existing.Any())
            {
                ShelfProducts.Add(new ShelfProduct(product, amount));
            } else
            {
                var index = ShelfProducts.IndexOf(existing.FirstOrDefault());
                //ShelfProducts[index].AddProductCount(amount);
            }
            */
          //  for(int i = 0; i < amount; i++)
          //  {
                Products.Add(product);
          //  }
        }
        public void RemoveProduct(int productId, int amount)
        {
            /*
             * Same thing here. I would do it this way, but this isn't want the assignment is asking for...
            var index = ShelfProducts.IndexOf(ShelfProducts.Where(p => p.GetId() == productId).FirstOrDefault());
            //ShelfProducts[index].RemoveProductCount(amount);
            */
            

        }

        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        public void PurchaseResolve(ShoppingCart cart)
        {

        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product FindProductById(int id)
        {
            return Products.FirstOrDefault(p => p.GetId() == id);
        }
        /*
        public void AddEmployee(Employee employee)
        {

        }

        public void RemoveEmployee(Employee employee)
        {

        }*/
    }
}
