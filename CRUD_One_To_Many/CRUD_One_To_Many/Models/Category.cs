using CRUD_One_To_Many.Models.Base;

namespace CRUD_One_To_Many.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
