using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class ProgrammingLanguageController : BaseController<ProgrammingLanguageModel>
    {
        public ProgrammingLanguageController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
            RedirectActionName = "Manage";
        }

        public override void date(ProgrammingLanguageModel model)
        {
        }

        public override Task GetFilePath(ProgrammingLanguageModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }

        public override Task PostFilePath(ProgrammingLanguageModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }
        public override bool Exist(ProgrammingLanguageModel language)
        {
            bool languageExist = _dbContext.ProgrammingLanguages.Any(x => x.ImageUrl == language.ImageUrl);
            if (languageExist)
            {
                ViewBag.Exist = "Language already exist please choose another laguage";

            }
            return languageExist;
        }
    }
    //    public class ProgrammingLanguageController : Controller
    //{
    //    private readonly PortfolioDbContext _dbContext;

    //    public ProgrammingLanguageController(PortfolioDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Add()
    //    {
    //        return View();
    //    }
    //    [HttpPost, Authorize]
    //    public IActionResult Add(ProgrammingLanguageModel language)
    //    {
    //        var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
    //        if(userId != null)
    //        {
    //            bool languageExist = _dbContext.ProgrammingLanguages.Any(x => x.ImageUrl == language.ImageUrl);
    //            if (languageExist)
    //            {
    //                ViewBag.Exist = "Language already exist please choose another laguage";

    //            }
    //            else
    //            {
    //                language.User_Id = Guid.Parse(userId.Value);

    //                if (ModelState.IsValid)
    //                {
    //                    _dbContext.ProgrammingLanguages.Add(language);
    //                    _dbContext.SaveChanges();
    //                    return RedirectToAction("Manage");
    //                }
    //                return View(language);
    //            }
    //        }
    //        return View();

    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Edit(Guid id)
    //    {
    //        var language = _dbContext.ProgrammingLanguages.FirstOrDefault(x => x.Id == id);
    //        if(language != null)
    //        {

    //            return View(language);

    //        }

    //        return RedirectToAction("Manage");
    //    }

    //    [HttpPost, Authorize]
    //    public IActionResult Edit(ProgrammingLanguageModel language)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var selectedLanguage = _dbContext.ProgrammingLanguages.FirstOrDefault(x => x.Id == language.Id);
    //           if(selectedLanguage != null)
    //            {
    //                _dbContext.ProgrammingLanguages.Update(selectedLanguage);
    //                _dbContext.SaveChanges();

    //                return RedirectToAction("Manage");
    //            }
    //           ViewBag.Message = "NotFound";
    //            return RedirectToAction("Manage");
    //        }
    //        return View(language);  
    //    }

    //    [HttpGet, Authorize]
    //    public IActionResult Delete(Guid id)
    //    {
    //        var selectedLanguage = _dbContext.ProgrammingLanguages.FirstOrDefault(x => x.Id == id);
    //        if(selectedLanguage != null)
    //        {
    //            _dbContext.ProgrammingLanguages.Remove(selectedLanguage);
    //            _dbContext.SaveChanges();

    //            return RedirectToAction("Manage");
    //        }
    //        return RedirectToAction("Manage");

    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Manage()
    //    {
    //        var languagelist = _dbContext.ProgrammingLanguages.ToList();
    //        return View(languagelist);
    //    }


}
