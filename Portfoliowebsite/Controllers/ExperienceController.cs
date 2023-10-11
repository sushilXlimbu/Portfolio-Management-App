using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class ExperienceController : BaseController<ExperienceModel>
    {
        public ExperienceController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
        }

        public override async Task GetFilePath(ExperienceModel userAbout, IFormFile Profilepic)
        {

        }
        public override async Task PostFilePath(ExperienceModel userAbout, IFormFile? Profilepic)
        {

        }
        
       

        public override void date(ExperienceModel experience)
        {
            string startData = experience.StartDate.ToString("MMMM yyyy");
            experience.startDateonly = startData;
            string endData = experience.EndDate.ToString("MMMM yyyy");
            experience.endDateonly = endData;
        }

        public override bool Exist(ExperienceModel model)
        {
            return false;
        }
    }
}





//    public class Old_ExperienceController : Controller
//    {
//        public readonly PortfolioDbContext _dbContext;

//        public Old_ExperienceController(PortfolioDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        [HttpGet, Authorize]
//        public IActionResult Add()
//        {

//            return View();
//        }
//        [HttpPost, Authorize]
//        public IActionResult Add(ExperienceModel experience)
//        {
//            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
//            experience.User_Id = Guid.Parse(userId.Value);
//            string startData = experience.StartDate.ToString("MMMM yyyy");
//            experience.startDateonly = startData;
//            string endData = experience.EndDate.ToString("MMMM yyyy");
//            experience.endDateonly = endData;

//            if (ModelState.IsValid)
//            {
               
//                _dbContext.Experiences.Add(experience);
//                _dbContext.SaveChanges();
//                return RedirectToAction("Portfolio", "User");
//            }
//            return View(experience);
//        }
//        [HttpGet, Authorize]
//        public IActionResult Edit(Guid id)
//        {
//            var experience = _dbContext.Experiences.FirstOrDefault(x => x.Id == id);

//            return View(experience);

//        }
//        [HttpPost, Authorize]
//        public IActionResult Edit(ExperienceModel editedExperience)
//        {
//            string startData = editedExperience.StartDate.ToString("MMMM yyyy");
//            editedExperience.startDateonly = startData;
//            string endData = editedExperience.EndDate.ToString("MMMM yyyy");
//            editedExperience.endDateonly = endData;

//            if (ModelState.IsValid)
//            {
                
//                _dbContext.Experiences.Update(editedExperience);
//                _dbContext.SaveChanges();
//                return RedirectToAction("Portfolio", "User");
//            }
//            return View(editedExperience);
//        }
//    }
//}
