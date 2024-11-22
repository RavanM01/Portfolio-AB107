using ProniaTask.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace ProniaTask.Models
{
    public class Slider : BaseEntity
    {
        
        [Required,StringLength(50,ErrorMessage ="Uzunlugu max 50 ola biler")]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
    }
}
