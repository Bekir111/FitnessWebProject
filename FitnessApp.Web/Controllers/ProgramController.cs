using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
	public class ProgramController : Controller
	{
		public IActionResult All()
		{
			return View();
		}
	}
}
