using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    [Authorize]
    public abstract class BaseController<T> : Controller where T : BaseModel
    {
        protected readonly PortfolioDbContext _dbContext;
        protected readonly IWebHostEnvironment _webHostEnvironment;
        public BaseController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        protected Guid UserId
        {
            get
            {
                {
                    System.Security.Claims.Claim? UserId = User.Claims.Where(c => c.Type == "Id").FirstOrDefault();
                    if (UserId != null)
                    {
                        Guid UId = Guid.Parse(UserId.Value);
                        return UId;
                    }
                    return Guid.Empty;

                }
            }
        }
        protected string RedirectActionName = "Index";

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(T model, IFormFile? Profilepic)
        {
            model.User_Id = UserId;
            date(model);

            if (!ModelState.IsValid)
                return View(model);

            if (Profilepic != null)
                await GetFilePath(model, Profilepic);

            bool exist = Exist(model);
            if (exist)
                TempData["aboutError"] = "One user can have only one About";
                TempData["alreadyExist"] = "Your selection already exist";
                return RedirectToAction("Portfolio", "User");

            await _dbContext.Set<T>().AddAsync(model);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Portfolio", "User");
            //return RedirectToAction(RedirectActionName);

        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            Guid? dataId;

            dataId = id;

            T ShowModel = await GetModel(dataId);
            if (ShowModel == null)
            {
                //TODO: Redirect to another page.
                return RedirectToAction("Manage");
            }

            return View(ShowModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(T model, IFormFile? Profilepic)
        {
            model.User_Id = UserId;

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (Profilepic != null)
            {
                PostFilePath(model, Profilepic);
            }

            date(model);
            bool exist = Exist(model);
            if (exist)
                return View();

            _dbContext.Set<T>().Update(model);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Portfolio", "User");
        }
        [HttpGet]
        public async Task<IActionResult> Manage()
        {
            var languagelist = await _dbContext.Set<T>().ToListAsync();
            return View(languagelist);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var selectedLanguage = await GetModel(id);
            if (selectedLanguage != null)
            {
                _dbContext.Set<T>().Remove(selectedLanguage);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Manage");
            }
            //TODO: Check this error
            TempData["deleteError"] = "Language Doesn't exist in the Database";

            return RedirectToAction("Manage");

        }
        public async Task<T> GetModel(Guid? id)
        {
            T SelectedData = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);       
            return SelectedData;
        }

        public virtual Task GetFilePath(T model, IFormFile picture)
        {
            return Task.CompletedTask;
        }
        public virtual Task PostFilePath(T model, IFormFile picture)
        {
            // Your code here
            return Task.CompletedTask;
        }

        public virtual void date(T model)
        {

        }
        public virtual bool Exist(T model)
        {
            return false;
        }
    }

}
