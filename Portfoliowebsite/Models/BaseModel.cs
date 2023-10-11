using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models
{
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User? Users { get; set; }
    }
}
