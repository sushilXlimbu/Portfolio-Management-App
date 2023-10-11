using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class AwardAndCertificationController : Controller
    {
        public readonly PortfolioDbContext _dbContext;

        public AwardAndCertificationController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet,Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost,Authorize]
        public IActionResult Add(AwardAndCertificationModel awardandcertification)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
                awardandcertification.User_Id = Guid.Parse(userId.Value);
                _dbContext.AwardAndCertifications.Add(awardandcertification);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
           return View(awardandcertification);
        }
        [HttpGet,Authorize]
        public IActionResult Edit(Guid id ) 
        {
            var selectedCertificate = _dbContext.AwardAndCertifications.FirstOrDefault(x => x.Id == id);

            return View(selectedCertificate); 
        }
        [HttpPost,Authorize]
        public IActionResult Edit(AwardAndCertificationModel certificate ) 
        {
            if (ModelState.IsValid)
            {
                _dbContext.AwardAndCertifications.Update(certificate);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
            return View(certificate);
        }
    }
}
