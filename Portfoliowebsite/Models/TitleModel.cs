using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class TitleModel
    {
        [Key]
        public Guid TitleId { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        public string ExperienceTitle { get; set; }
        public string EducationTitle { get; set; }
        public string SkillsTitle { get; set; }
        public string IntrestTitle { get; set; }
        public string AwardTitle { get; set; }
    }
}
