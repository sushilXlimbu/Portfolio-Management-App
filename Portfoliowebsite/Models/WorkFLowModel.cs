using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfoliowebsite.Models
{
    public class WorkFLowModel : BaseModel
    {
    
        [Required]
        public string WorkFlowList { get; set; }
    }
}
