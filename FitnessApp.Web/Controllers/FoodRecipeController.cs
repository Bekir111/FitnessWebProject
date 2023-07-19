
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.FoodRecipe;

    using static Common.NotificationMessagesConstants;
    public class FoodRecipeController : BaseController
    {
        private readonly IFoodRecipeService foodRecipeService;

        public FoodRecipeController(IFoodRecipeService foodRecipeService)
        {
            this.foodRecipeService = foodRecipeService;
        }

        public async Task<IActionResult> All()
        {
            var recipes = await foodRecipeService.GetAllFoodRecipes();
            return View(recipes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new FoodRecipeFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(FoodRecipeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var userId = this.User.GetId();

                await foodRecipeService.AddFoodRecipeAsync(model,userId);

                this.TempData[SuccessMessage] = "Food Recipe was added successfully!";

                return RedirectToAction("All", "FoodRecipe");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        public async Task<IActionResult> Detail(string id)
        {
            try
            {
                var model = await this.foodRecipeService.GetFoodRecipeByIdForDetail(id);

                return View(model);
            }
            catch (Exception)
            {
                return RedirectToAction("All", "FoodRecipe");
            }
        }
    }
}
