using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class ProgrammingLanguageModel
    {
        [Key]
        public Guid ProgrammingLanguageId { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}
