using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
	public class ContactsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
