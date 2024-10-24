using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Store
    {
        public Product[] Products=new Product[0];
        
        
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[^1] = product;
        }
        

        public void RemoveProductByNo(int no)
        {
            int j = 0;
            Product[] newproducts= new Product[Products.Length-1];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No != no)
                {
                    newproducts[j] = Products[i];
                    j++;
                }
            }    
            Products = newproducts;
        }

        public void GetProduct(int? no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Console.WriteLine($"{Products[i].No}\n{Products[i].Name}\n{Products[i].Price}");
                }
            }
        }
        public void FilterProductsByType(Type type)
        {
            for (int i = 0; i < Products.Length; i++) {
                if (Products[i].Type == type) {
                    Console.WriteLine();
                    }
            }
         
        }



    }
}
