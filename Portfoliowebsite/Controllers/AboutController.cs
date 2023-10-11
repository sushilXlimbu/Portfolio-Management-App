using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;
using System.Linq;

namespace Portfoliowebsite.Controllers
{
    public class AboutController : BaseController<AboutModel>
    {
        public AboutController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
        }

        //public override string ValidateMe(AboutModel model)
        //{
        //    if (model.Address.Length < 3)
        //        return "Address is invalid";
        //    return "";
        //}
        public override async Task GetFilePath(AboutModel userAbout, IFormFile Profilepic)
        {
            string wwwRootPath = Path.Combine(_webHostEnvironment.WebRootPath, "img");
            string fileName = Guid.NewGuid().ToString() + Profilepic.FileName;
            string fullpath = Path.Combine(wwwRootPath, fileName);
            string fullpathforDB = Path.Combine("/img/", fileName); 
            userAbout.ProfilePicture = fullpathforDB;
            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                await Profilepic.CopyToAsync(fileStream);
            }
            
        }
        public override async Task PostFilePath(AboutModel userAbout, IFormFile? Profilepic)
        {
            
                string wwwRootPath = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                string fileName = Guid.NewGuid().ToString() + Profilepic.FileName;
                string fullpath = Path.Combine(wwwRootPath, fileName);
                string fullpathforDB = Path.Combine("/img/", fileName);
                userAbout.ProfilePicture = fullpathforDB;
                using (var fileStream = new FileStream(fullpath, FileMode.Create))
                {
                    await Profilepic.CopyToAsync(fileStream);
                }

            
        }
     
        public override void date(AboutModel model)
        {
        }

        public override bool Exist(AboutModel model)
        {
            bool about = _dbContext.About.Any();
            return about;
        }
    }




    //public class Old_AboutController : Controller
    //{
    //    private readonly IWebHostEnvironment _webHostEnvironment;
    //    private readonly PortfolioDbContext _dbContext;
    //    public Old_AboutController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment)
    //    {
    //        _dbContext = dbContext;
    //        _webHostEnvironment = webHostEnvironment;
    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }
    //    [HttpPost, Authorize]
    //    public async Task<IActionResult> Create(AboutModel userAbout, IFormFile Profilepic)
    //    {
    //        bool create = _dbContext.About.Any();
    //        if (create == false)
    //        {
    //            string wwwRootPath = Path.Combine(_webHostEnvironment.WebRootPath, "img");
    //            string fileName = Guid.NewGuid().ToString() + Profilepic.FileName;
    //            string fullpath = Path.Combine(wwwRootPath, fileName);
    //            string fullpathforDB = Path.Combine("/img/", fileName);
    //            userAbout.ProfilePicture = fullpathforDB;

    //            System.Security.Claims.Claim? UserId = User.Claims.Where(c => c.Type == "Id").FirstOrDefault();
    //            if (UserId != null)
    //            {

    //                userAbout.User_Id = Guid.Parse(UserId.Value);
    //                if (ModelState.IsValid)
    //                {
    //                    using (var fileStream = new FileStream(fullpath, FileMode.Create))
    //                    {
    //                        await Profilepic.CopyToAsync(fileStream);
    //                    }
    //                    await _dbContext.About.AddAsync(userAbout);
    //                    await _dbContext.SaveChangesAsync();
    //                    return RedirectToAction("Portfolio", "User");
    //                }
    //                return View(userAbout);


    //            }
    //            return RedirectToAction("Portfolio", "User");
    //        }

    //        ViewBag.AboutError = "User About Already Exists";
    //        return View();



    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Edit()
    //    {
    //        var UserId = User.Claims.Where(c => c.Type == "Id").FirstOrDefault();

    //        var userId = Guid.Parse(UserId.Value);
    //        AboutModel uAbout = _dbContext.About.FirstOrDefault(x => x.User_Id == userId);

    //        if (uAbout != null)
    //        {
    //            return View(uAbout);
    //        }

    //        return View();
    //    }

    //    [HttpPost, Authorize]
    //    public async Task<IActionResult> Edit(AboutModel userAbout, IFormFile? Profilepic)
    //    {
    //        if (Profilepic != null)
    //        {
    //            string wwwRootPath = Path.Combine(_webHostEnvironment.WebRootPath, "img");
    //            string fileName = Guid.NewGuid().ToString() + Profilepic.FileName;
    //            string fullpath = Path.Combine(wwwRootPath, fileName);
    //            string fullpathforDB = Path.Combine("/img/", fileName);
    //            userAbout.ProfilePicture = fullpathforDB;
    //            using (var fileStream = new FileStream(fullpath, FileMode.Create))
    //            {
    //                await Profilepic.CopyToAsync(fileStream);
    //            }

    //        }


    //        if (ModelState.IsValid)
    //        {

    //            //Change tracking
    //            _dbContext.About.Update(userAbout);
    //            _dbContext.SaveChanges();
    //            return RedirectToAction("Portfolio", "User");
    //        }
    //        return View(userAbout);

                                             


    //    }
    //    [HttpGet, Authorize]
    //    public IActionResult Portfolio()
    //    {
    //        var about = _dbContext.About.ToList();

    //        return View(about);
    //    }
    //}
}
