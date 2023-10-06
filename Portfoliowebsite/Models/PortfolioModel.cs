using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models
{
    public class PortfolioModel
    {
        
        public string? FName { get; set; }
        
        public string? LName { get; set; }
        
        public string? Address { get; set; }
        public string? ProfileEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ProfileDescription { get; set; }
    }
}
