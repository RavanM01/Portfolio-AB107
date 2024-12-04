using NestTask.Models.Base;

namespace NestTask.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
