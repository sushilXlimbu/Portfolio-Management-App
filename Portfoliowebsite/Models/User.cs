using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models
{
    public class User
    {
        [Key]
        public Guid User_Id { get; set; }
        [Required]
        public string User_Name { get; set;}
        [Required]
        public string User_Email { get; set;}
        [Required]
        public string Password { get; set;}
        
        public AboutModel About { get; set; }
        public List<SocialMediaModel> SocialMediaList { get; set; }
        public List<ExperienceModel> ExperienceList { get; set; }
        public List<EducationModel> EducationList { get; set; }
        public List<ProgrammingLanguageModel> ProgrammingLanguageList { get; set; }
        public List<WorkFLowModel> WorkFLowList { get; set; }
        public IntrestModel Intrest { get; set; }
        public List<AwardAndCertificationModel> AwardAndCertificationList { get; set; }
        public TitleModel Title { get; set;}




    }
}
