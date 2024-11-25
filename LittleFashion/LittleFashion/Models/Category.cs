using LittleFashion.Models.Base;

namespace LittleFashion.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
