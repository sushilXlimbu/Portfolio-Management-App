using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class ExperienceController : Controller
    {
        public readonly PortfolioDbContext _dbContext;

        public ExperienceController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet, Authorize]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost, Authorize]
        public IActionResult Add(ExperienceModel experience)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
            experience.User_Id = Guid.Parse(userId.Value);
            string startData = experience.StartDate.ToString("MMMM yyyy");
            experience.startDateonly = startData;
            string endData = experience.EndDate.ToString("MMMM yyyy");
            experience.endDateonly = endData;

            if (ModelState.IsValid)
            {
               
                _dbContext.Experiences.Add(experience);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
            return View(experience);
        }
        [HttpGet, Authorize]
        public IActionResult Edit(Guid id)
        {
            var experience = _dbContext.Experiences.FirstOrDefault(x => x.ExperienceId == id);

            return View(experience);

        }
        [HttpPost, Authorize]
        public IActionResult Edit(ExperienceModel editedExperience)
        {
            string startData = editedExperience.StartDate.ToString("MMMM yyyy");
            editedExperience.startDateonly = startData;
            string endData = editedExperience.EndDate.ToString("MMMM yyyy");
            editedExperience.endDateonly = endData;

            if (ModelState.IsValid)
            {
                
                _dbContext.Experiences.Update(editedExperience);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
            return View(editedExperience);
        }
    }
}
