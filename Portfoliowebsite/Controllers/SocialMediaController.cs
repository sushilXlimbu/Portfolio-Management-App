using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class SocialMediaController : Controller
    {
        public readonly PortfolioDbContext _dbContext;

        public SocialMediaController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet,Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost,Authorize]
        public IActionResult Add(SocialMediaModel socialMedia)
        {
            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
            socialMedia.User_Id = Guid.Parse(userId.Value);
            if (ModelState.IsValid)
            {

                _dbContext.SocialMedia.Add(socialMedia);
                _dbContext.SaveChanges();
                return RedirectToAction("Manage");
            }
            return View(socialMedia);
        }
        [HttpGet, Authorize]
        public IActionResult Edit(Guid id)
        {
            var selected = _dbContext.SocialMedia.FirstOrDefault(x => x.SocialMediaId == id);
            return View(selected);
        }
        [HttpPost, Authorize]
        public IActionResult Edit(SocialMediaModel selectedsocial)
        {
            if (ModelState.IsValid)
            {
                _dbContext.SocialMedia.Update(selectedsocial);
                _dbContext.SaveChanges();
                return RedirectToAction("Manage");
            }
            return View(selectedsocial);
        }
        [HttpGet, Authorize]
        public IActionResult Delete(Guid id)
        {
            var selected = _dbContext.SocialMedia.FirstOrDefault(x => x.SocialMediaId == id);
            _dbContext.SocialMedia.Remove(selected);
            _dbContext.SaveChanges();
            return RedirectToAction("Manage");
        }
        [HttpGet,Authorize]
        public IActionResult Manage()
        {
            var socialmediaList = _dbContext.SocialMedia.ToList();
            return View(socialmediaList);
        }
    }
}
