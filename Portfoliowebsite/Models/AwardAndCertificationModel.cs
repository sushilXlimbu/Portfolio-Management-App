using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class AwardAndCertificationModel
    {
        [Key]
        public Guid AwardAndCertification { get; set; }
        
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User? Users { get; set; }
        [Required]
        public string AwardTitle { get; set; }

    }
}
