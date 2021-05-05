using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGenerals
{
    public class Store
    {
        private int Id;
        private string Name;
        private List<Product> Products;
        private List<ShelfProduct> ShelfProducts;
        
        /*
         * Extra stuff that is not part of the assignment
        private static int instanceCount = 0;

        public Store(string name)
        {
            Name = name;
            Id = ++instanceCount;
        }
        */
        public void AddProduct(Product product, int amount)
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
            for(int i = 0; i < amount; i++)
            {
                Products.Add(product);
            }
        }
        public void RemoveProduct(int productId, int amount)
        {
            /*
             * Same thing here. I would do it this way, but this isn't want the assignment is asking for...
            var index = ShelfProducts.IndexOf(ShelfProducts.Where(p => p.GetId() == productId).FirstOrDefault());
            //ShelfProducts[index].RemoveProductCount(amount);
            */
            int removeCount = 0;
            for(int i = 0; i < Products.Count; i++)
            {
                if(Products[i].GetId() == productId)
                {
                    Products.RemoveAt(i);
                    removeCount++;
                }
                if(removeCount >= amount)
                {
                    break;
                }
            }
        }
        public void PurchaseResolve(ShoppingCart cart)
        {
            //Not going to lie, Idk what to do here
        }

        public void AddEmployee(Employee employee)
        {
            //I don't have an employee class or list
        }

        public void RemoveEmployee(Employee employee)
        {
            //I don't have an employee class or list
        }
    }
}
