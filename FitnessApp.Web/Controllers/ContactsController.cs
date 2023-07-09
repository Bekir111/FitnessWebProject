
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [AllowAnonymous]
    public class ContactsController : BaseController
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
