using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{


    public class AboutModel : BaseModel
    {
        [Required(ErrorMessage = "The First Name field is required.")]
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
        [ValidateNever]
        public string? ProfilePicture { get; set; }
    }
}
