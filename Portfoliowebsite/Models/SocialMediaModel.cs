using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class SocialMediaModel
    {
        [Key]
        public Guid SocialMediaId { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        public string ImageUrl { get; set; }
        public string SocialMediaLink { get; set; }
    }
}
