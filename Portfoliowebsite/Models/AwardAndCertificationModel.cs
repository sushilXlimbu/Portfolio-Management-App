using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class AwardAndCertificationModel:BaseModel
    {
     
        [Required]
        public string AwardTitle { get; set; }

    }
}
