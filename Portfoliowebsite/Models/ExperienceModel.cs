using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class ExperienceModel
    {
        [Key]
        public Guid ExperienceId { get; set; }
        
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        [Required]
        public string Position { get; set;}
        [Required]
        public string CompanyName { get; set;}
        [Required]
        public string JobDescription { get; set;}
        [Required]
        public DateTime StartDate { get; set; } 
        
        [Required]
        public DateTime EndDate { get;set;}
        public string? startDateonly { get; set; }
        public string? endDateonly { get; set; }

    }
}
