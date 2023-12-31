﻿
namespace FitnessApp.Web.Controllers
{
    using System.Diagnostics;
    
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;   

    using FitnessApp.Web.ViewModels.Home;
    using FitnessApp.Web.Infrastructure.Extensions;

    using static FitnessApp.Common.GeneralApplicationConstants;

    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            if (this.User.IsAdmin())
            {
                return RedirectToAction("Index","Home", new { Area = AdminAreaName});
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404)
            {
                return View("Error404");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}