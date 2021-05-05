using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikesGenerals
{
    public class Customer
    {
        private readonly int Id;
        private string Name;
        private string Address;
        private static int count = 0;

        public Customer()
        {
            Id = ++count;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
