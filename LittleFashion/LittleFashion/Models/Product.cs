using LittleFashion.Models.Base;

namespace LittleFashion.Models
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImgUrl { get; set; }
        public Category Category { get; set; }

    }
}
