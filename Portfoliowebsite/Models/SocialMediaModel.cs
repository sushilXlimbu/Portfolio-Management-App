using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class SocialMediaModel : BaseModel
    {
        public string ImageUrl { get; set; }
        public string SocialMediaLink { get; set; }
    }
}
