using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class EducationModel
    {
        [Key]
        public Guid EducationId { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        [Required]
        public string UniversityName { get; set; }
        [Required]
        public string EducationField { get; set; }
        [Required]
        public float Gpa { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string? startDateonly { get; set; }
        public string? endDateonly { get; set; }
        

        
    }
}
