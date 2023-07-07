using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
