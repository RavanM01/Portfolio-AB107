using Riode.Models.Base;

namespace Riode.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string SKU { get; set; } 
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public int BrandId  { get; set; }
        public Brand Brand { get; set; }
        public List<ProductImages>? ProductImages { get; set; }
    }
}
