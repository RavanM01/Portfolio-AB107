namespace CRUD_One_To_Many.DTOs.Product
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public string CategoryId { get; set; }
    }
}
