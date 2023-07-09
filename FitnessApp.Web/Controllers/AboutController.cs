using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
	[AllowAnonymous]
	public class AboutController : BaseController
    {
		public IActionResult All()
		{
			return View();
		}
	}
}
