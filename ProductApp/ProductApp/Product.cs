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
        private double _price;
        public string Name { get; set; }
        public double Price { get { return _price; } set { if (value > 0) { _price = value; } else { throw new PriceMustBeGratherThanZeroException("Qiymet 0-dan boyuk olmalidir"); } } }
        public Type Type{ get; set; }







    }
}
