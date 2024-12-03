using Riode.Models;
using System.ComponentModel.DataAnnotations;

namespace Riode.Areas.Dashboard.ViewModels.Product
{
    public record CreateProductVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SKU { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public int BrandId { get; set; }
        public IFormFile MainPhoto { get; set; }
        public List<IFormFile>? Images { get; set; }
    }
}
