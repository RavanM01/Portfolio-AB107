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
                    Console.WriteLine($"\n{Products[i].No}\n{Products[i].Name}\n{Products[i].Price}\n{Products[i].Type}\n");
                }
            }
        }
        public void FilterProductsByType(Type type)
        {
            //string types = Enum.GetName(typeof(Type), 1);

            for (int i = 0; i < Products.Length; i++) {
                if (Products[i].Type == type) {
                    Console.WriteLine($"\n{Products[i].No}\n{Products[i].Name}\n{Products[i].Price}\n{Products[i].Type}\n");
                   
                }
            }
         
        }
        public void FilterProductsByName(string name)
        {
            Product[] namearr = new Product[0];
            int j = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref namearr, namearr.Length+1);
                    namearr[j] = Products[i];
                    Console.WriteLine($" {namearr[j].No} {namearr[j].Name} {namearr[j].Type} {namearr[j].Price} ");
                    j++;
                }
            }

        }



    }
}
