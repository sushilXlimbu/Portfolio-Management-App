using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models.ViewModels
{
    public class UserView
    {
        public Guid User_Id { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public string User_Email { get; set; }
        [Required]
        public string Password { get; set; }
        public AboutModel? About { get; set; }
        public List<EducationModel>? EducationList { get; set; }
        public List<ExperienceModel>? ExperienceList { get; set; }
        public List<ProgrammingLanguageModel>? ProgrammingLanguageList { get; set; }
        public List<WorkFLowModel>? WorkFLowList { get; set; }
        public List<AwardAndCertificationModel>? AwardAndCertificationList { get; set; }

    }
}
