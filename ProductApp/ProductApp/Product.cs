using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        public Product(string name, double price,Type type)
        {
            ++_no;
            No = _no;
            Type = type;
            Name = name;
            Price = price;
        }
        private static int _no;
        public int No { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public Type Type{ get; set; }







    }
}
