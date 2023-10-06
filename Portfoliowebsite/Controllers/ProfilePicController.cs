using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    public class ProfilePicController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProfilePicController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet,Authorize]
        public IActionResult Add()
        {

            return View();
        }
        [HttpPost,Authorize]
        public async Task<IActionResult> Add(IFormFile picture)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(picture.FileName);
            string extension = Path.GetExtension(picture.FileName);


            return View();
        }
    }
}
