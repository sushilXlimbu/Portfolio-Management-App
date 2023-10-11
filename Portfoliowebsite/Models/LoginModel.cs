using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models
{
    public class LoginModel : BaseModel
    {
        public Guid? User_Id { get; set; }

        [Required]
        public string User_Name { get; set; }
        
        public string? User_Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
