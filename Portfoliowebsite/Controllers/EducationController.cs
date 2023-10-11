using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;
using System;

namespace Portfoliowebsite.Controllers
{
    public class EducationController : BaseController<EducationModel>
    {
        public EducationController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
        }

        public override async Task GetFilePath(EducationModel userAbout, IFormFile Profilepic)
        {

        }
        public override async Task PostFilePath(EducationModel userAbout, IFormFile? Profilepic)
        {

        }
    


        public override void date(EducationModel Education)
        {
            string startData = Education.StartDate.ToString("MMMM yyyy");
            Education.startDateonly = startData;
            string endData = Education.EndDate.ToString("MMMM yyyy");
            Education.endDateonly = endData;
        }

        public override bool Exist(EducationModel model)
        {
            return false;
        }

        //public class Old_EducationController : Controller
        //{
        //    public readonly PortfolioDbContext _dbContext;

        //    public Old_EducationController(PortfolioDbContext dbContext)
        //    {
        //        _dbContext = dbContext;
        //    }
        //    [HttpGet, Authorize]
        //    public IActionResult Add()
        //    {

        //        return View();
        //    }
        //    [HttpPost, Authorize]
        //    public IActionResult Add(EducationModel education)
        //    {
        //        var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
        //        education.User_Id = Guid.Parse(userId.Value);
        //        string startDate = education.StartDate.ToString("MMMM yyyy");
        //        education.startDateonly = startDate;
        //        string endDate = education.EndDate.ToString("MMMM yyyy");
        //        education.endDateonly = endDate;

        //        if (ModelState.IsValid)
        //        {

        //            _dbContext.Educations.Add(education);
        //            _dbContext.SaveChanges();
        //            return RedirectToAction("Portfolio", "User");
        //        }
        //        return View(education);
        //    }
        //    [HttpGet, Authorize]
        //    public IActionResult Edit(Guid id)
        //    {
        //        var education = _dbContext.Educations.FirstOrDefault(x => x.Id == id);
        //        return View(education);
        //    }
        //    [HttpPost, Authorize]
        //    public IActionResult Edit(EducationModel editedEducation)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            string startDate = editedEducation.StartDate.ToString("MMMM yyyy");
        //            editedEducation.startDateonly = startDate;
        //            string endDate = editedEducation.EndDate.ToString("MMMM yyyy");
        //            editedEducation.endDateonly = endDate;
        //            _dbContext.Educations.Update(editedEducation);
        //            _dbContext.SaveChanges();
        //            return RedirectToAction("Portfolio", "User");
        //        }
        //        return View(editedEducation);
        //    }
        //}
    }
}
