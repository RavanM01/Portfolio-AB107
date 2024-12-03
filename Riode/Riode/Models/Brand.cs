using Riode.Models.Base;

namespace Riode.Models
{
    public class Brand:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
