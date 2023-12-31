﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfoliowebsite.Data;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Controllers
{
    [Authorize]
    public class WorkFlowController : BaseController<WorkFLowModel>
    {
        public WorkFlowController(PortfolioDbContext dbContext, IWebHostEnvironment webHostEnvironment) : base(dbContext, webHostEnvironment)
        {
        }

        public override void date(WorkFLowModel model)
        {
        }

        public override Task GetFilePath(WorkFLowModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }

        public override Task PostFilePath(WorkFLowModel model, IFormFile picture)
        {
            return Task.CompletedTask;
        }
        public override bool Exist(WorkFLowModel language)
        {
            
            return false;
        }
    }
    //public class WorkFlowController : Controller
    //{
    //    public readonly PortfolioDbContext _dbContext;

    //    public WorkFlowController(PortfolioDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }

    //       [HttpGet]
    //    public IActionResult Add()
    //    {
    //        return View();
    //    }
    //    [HttpPost,Authorize]
    //    public IActionResult Add( WorkFLowModel work)
    //    {
    //        var userId = User.Claims.FirstOrDefault(x => x.Type == "Id");
    //        work.User_Id = Guid.Parse(userId.Value);
    //        if (ModelState.IsValid)
    //        {                
    //            _dbContext.WorkFLows.Add(work);
    //            _dbContext.SaveChanges();
    //            return RedirectToAction("Manage");
    //        }
    //        return View(work);
    //    }
    //    [HttpGet,Authorize]
    //    public IActionResult Edit( Guid id)
    //    {
    //        var selectedworkflow = _dbContext.WorkFLows.FirstOrDefault(x => x.Id == id);

    //        return View(selectedworkflow);
    //    }
    //    [HttpPost,Authorize]
    //    public IActionResult Edit( WorkFLowModel work)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _dbContext.WorkFLows.Update(work);
    //            _dbContext.SaveChanges();
    //            return RedirectToAction("Manage");
    //        }
    //        return View(work);
    //    }
    //    [HttpGet,Authorize]
    //    public IActionResult Delete( Guid id)
    //    {
    //        var work = _dbContext.WorkFLows.FirstOrDefault(x => x.Id == id);
    //        _dbContext.WorkFLows.Remove(work);
    //        _dbContext.SaveChanges();
    //        return RedirectToAction("Manage");
    //    }
    //    [HttpGet,Authorize]
    //    public IActionResult Manage()
    //    {
    //        var worklist = _dbContext.WorkFLows.ToList();
    //        return View(worklist);
    //    }
    //}
}
