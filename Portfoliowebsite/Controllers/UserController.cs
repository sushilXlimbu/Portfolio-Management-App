using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;
using Portfoliowebsite.Models.ViewModels;
using System.Security.Claims;

namespace Portfoliowebsite.Controllers
{
    public class UserController : Controller
    {
       
        private readonly PortfolioDbContext _dbContext;
        public UserController(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private LoginModel UserAuthentication(LoginModel data)
        {
            User user_data = _dbContext.Users.FirstOrDefault(x => x.User_Name == data.User_Name && x.Password == data.Password);
            if(user_data != null)
            {
                LoginModel userView_data = new LoginModel()
                {
                    User_Id = user_data.User_Id,
                    User_Name = user_data.User_Name,
                    Password = user_data.Password,
                    User_Email = user_data.User_Email,
                };
                return userView_data;
            }
            return null;
        }
        [HttpGet,Authorize]
        public IActionResult Index()
        {
            //var UserId = User.Claims.FirstOrDefault(c => c.Type == "Id");
            //var userId = Guid.Parse(UserId.Value);
            //AboutModel about = _dbContext.About.FirstOrDefault(e => e.User_Id == userId);
            //List<ExperienceModel> experiencedata = _dbContext.Experiences.ToList();
            //List<EducationModel> educattiondata = _dbContext.Educations.ToList();
            //List<WorkFLowModel> workflowdata = _dbContext.WorkFLows.ToList();
            //List<AwardAndCertificationModel> awarddata = _dbContext.AwardAndCertifications.ToList();
            //List<SocialMediaModel> socialmediadata = _dbContext.SocialMedia.ToList();
            //List<ProgrammingLanguageModel> programmingLanguage = _dbContext.ProgrammingLanguages.ToList();
            //TitleModel title = _dbContext.Titles.FirstOrDefault(e => e.User_Id == userId);
            //var viewModel = new ViewModel
            //{
            //    AboutModel = about,
            //    ExperienceModel = experiencedata,
            //    EducationModel = educattiondata,
            //    WorkFLowModel = workflowdata,
            //    AwardAndCertificationModel = awarddata,
            //    SocialMediaModels = socialmediadata,
            //    ProgrammingLanguageModel = programmingLanguage,
            //    TitleModel = title,



            //};

            //return View(viewModel);
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(UserView U_data)
        {
            if(ModelState.IsValid)
            {
                User user_data = new User()
                {
                    User_Id = U_data.User_Id,
                    User_Name = U_data.User_Name,
                    Password = U_data.Password,
                    User_Email = U_data.User_Email,
                };
                await _dbContext.Users.AddAsync(user_data);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            
            return View(U_data);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel Login_data)
        {
            
            if(ModelState.IsValid)
            {
                LoginModel user =  UserAuthentication(Login_data);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    ViewBag.error = "Invalid Login";
                    return View();
                }

                var claims = new List<Claim>
                {
                    
                    new Claim("Id",user.User_Id.ToString()),
                    new Claim(ClaimTypes.Email,user.User_Email),
                    new Claim(ClaimTypes.Name,user.User_Name),

                };
                var claimsIdentity = new ClaimsIdentity(
                    claims,CookieAuthenticationDefaults.AuthenticationScheme
                    );

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)
                    );
                ViewBag.status = "LoggedIn";
                return RedirectToAction("Index");
            }
            
            return View(Login_data);
        }
        [HttpGet,Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme
            );
            return RedirectToAction("Login");
        }
        [HttpGet, Authorize]
        public IActionResult Portfolio()
        {
            var UserId = User.Claims.FirstOrDefault(c => c.Type == "Id");
            var userId = Guid.Parse(UserId.Value);
            AboutModel about = _dbContext.About.FirstOrDefault(e => e.User_Id == userId);
            List<ExperienceModel> experiencedata = _dbContext.Experiences.ToList();
            List<EducationModel> educattiondata = _dbContext.Educations.ToList();
            List<WorkFLowModel> workflowdata = _dbContext.WorkFLows.ToList();
            List<AwardAndCertificationModel> awarddata = _dbContext.AwardAndCertifications.ToList();
            List<SocialMediaModel> socialmediadata = _dbContext.SocialMedia.ToList();
            List<ProgrammingLanguageModel> programmingLanguage = _dbContext.ProgrammingLanguages.ToList();
            TitleModel title = _dbContext.Titles.FirstOrDefault(e => e.User_Id == userId);
            var viewModel = new ViewModel
            {
                AboutModel = about,
                ExperienceModel = experiencedata,
                EducationModel = educattiondata,
                WorkFLowModel = workflowdata,
                AwardAndCertificationModel = awarddata,
                SocialMediaModels = socialmediadata,
                ProgrammingLanguageModel = programmingLanguage,
                TitleModel = title
            };

            return View(viewModel);
        }
        
    }
}
