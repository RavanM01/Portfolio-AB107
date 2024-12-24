using System.ComponentModel.DataAnnotations;

namespace NestTask.Areas.Dashboard.ViewModels.Product
{
    public record CreateProductVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public double Price { get; set; }     
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public List<int> TagIds { get; set; }
        public IFormFile MainPhoto { get; set; }
        public List<IFormFile>? Images { get; set; }
    }
}
