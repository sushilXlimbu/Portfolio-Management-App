using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class ProgrammingLanguageModel : BaseModel
    {
  
        [Required]
        public string ImageUrl { get; set; }

    }
}
