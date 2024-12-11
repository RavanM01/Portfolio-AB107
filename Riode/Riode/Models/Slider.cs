using Riode.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Riode.Models
{
    public class Slider :BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [NotMapped]
        public IFormFile file { get; set; }
    }
}
