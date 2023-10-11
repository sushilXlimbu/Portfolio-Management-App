using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class SocialMediaController : BaseController<SocialMediaModel>
    {
        public SocialMediaController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
        }
   
        public override void date(SocialMediaModel model)
        {
        }

        public override Task GetFilePath(SocialMediaModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }

        public override Task PostFilePath(SocialMediaModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }
        public override bool Exist(SocialMediaModel language)
        {
            bool languageExist = _dbContext.ProgrammingLanguages.Any(x => x.ImageUrl == language.ImageUrl);
            if (languageExist)
            {
                ViewBag.Exist = "Language already exist please choose another laguage";

            }
            return languageExist;
        }
    }
    //public class SocialMediaController : Controller
    //{
    //    public readonly PortfolioDbContext _dbContext;

    //    public SocialMediaController(PortfolioDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }
    //    [HttpGet,Authorize]
    //    public IActionResult Add()
    //    {
    //        return View();
    //    }

    //    [HttpPost,Authorize]
    //    public IActionResult Add(SocialMediaModel socialMedia)
    //    {
    //        var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
    //        socialMedia.User_Id = Guid.Parse(userId.Value);
    //        if (ModelState.IsValid)
    //        {

    //            _dbContext.SocialMedia.Add(socialMedia);
    //            _dbContext.SaveChanges();
    //            return RedirectToAction("Manage");
    //        }
    //        return View(socialMedia);
    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Edit(Guid id)
    //    {
    //        var selected = _dbContext.SocialMedia.FirstOrDefault(x => x.Id == id);
    //        return View(selected);
    //    }
    //    [HttpPost, Authorize]
    //    public IActionResult Edit(SocialMediaModel selectedsocial)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _dbContext.SocialMedia.Update(selectedsocial);
    //            _dbContext.SaveChanges();
    //            return RedirectToAction("Manage");
    //        }
    //        return View(selectedsocial);
    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Delete(Guid id)
    //    {
    //        var selected = _dbContext.SocialMedia.FirstOrDefault(x => x.Id == id);
    //        _dbContext.SocialMedia.Remove(selected);
    //        _dbContext.SaveChanges();
    //        return RedirectToAction("Manage");
    //    }
    //    [HttpGet,Authorize]
    //    public IActionResult Manage()
    //    {
    //        var socialmediaList = _dbContext.SocialMedia.ToList();
    //        return View(socialmediaList);
    //    }
    //}
}
