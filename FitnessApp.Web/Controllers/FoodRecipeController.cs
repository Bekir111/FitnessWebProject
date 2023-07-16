
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class FoodRecipeController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
