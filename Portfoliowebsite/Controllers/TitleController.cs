using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfoliowebsite.Controllers
{
    public class TitleController : Controller
    {
        [HttpGet,Authorize]
        public IActionResult Edit()
        {

            return View();
        }
    }
}
