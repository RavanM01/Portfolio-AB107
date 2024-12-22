using CRUD_One_To_Many.Models.Base;

namespace CRUD_One_To_Many.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
