using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class AboutModel
    {
        [Key] 
        public Guid Aboutid { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ProfileEmail { get; set;}
        [Required]
        public string PhoneNumber { get; set;}
        [Required]
        public string ProfileDescription { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
