using FitnessApp.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Areas.Admin.Controllers
{
	public class UserController : BaseAdminController
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		public async Task<IActionResult> All()
		{
			var users = await this.userService.GetUsers();

			return View(users);
		}
	}
}
