namespace CRUD_One_To_Many.DTOs.Product
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string CategoryId { get; set; }
    }
}
