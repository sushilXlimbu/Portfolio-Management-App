using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;
using System;

namespace Portfoliowebsite.Controllers
{
    public class EducationController : Controller
    {
        public readonly PortfolioDbContext _dbContext;

        public EducationController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet, Authorize]
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost, Authorize]
        public IActionResult Add(EducationModel education)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
            education.User_Id = Guid.Parse(userId.Value);
            string startDate = education.StartDate.ToString("MMMM yyyy");
            education.startDateonly = startDate;
            string endDate = education.EndDate.ToString("MMMM yyyy");
            education.endDateonly = endDate;

            if (ModelState.IsValid)
            {
                
                _dbContext.Educations.Add(education);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
            return View(education);
        }
        [HttpGet, Authorize]
        public IActionResult Edit(Guid id)
        {
            var education = _dbContext.Educations.FirstOrDefault(x => x.EducationId == id);
            return View(education);
        }
        [HttpPost, Authorize]
        public IActionResult Edit(EducationModel editedEducation)
        {
            if (ModelState.IsValid)
            {
                string startDate = editedEducation.StartDate.ToString("MMMM yyyy");
                editedEducation.startDateonly = startDate;
                string endDate = editedEducation.EndDate.ToString("MMMM yyyy");
                editedEducation.endDateonly = endDate;
                _dbContext.Educations.Update(editedEducation);
                _dbContext.SaveChanges();
                return RedirectToAction("Portfolio", "User");
            }
            return View(editedEducation);
        }
    }
}
