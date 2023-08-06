using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
