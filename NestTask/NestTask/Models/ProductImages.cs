using NestTask.Models.Base;

namespace NestTask.Models
{
    public class ProductImages:BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool Primary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    
    }
}
