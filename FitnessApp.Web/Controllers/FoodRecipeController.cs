
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
            bool isExist = await this.foodRecipeService.IsFoodRecipeExist(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "This food recipe doesn't exist!";
                return RedirectToAction("All", "FoodRecipe");
            }

            try
            {
                var model = await this.foodRecipeService.GetFoodRecipeByIdForDetail(id);

                return View(model);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "This food recipe doesnt exist!";
                return RedirectToAction("All", "FoodRecipe");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool isExist = await this.foodRecipeService.IsFoodRecipeExist(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "This food recipe doesn't exist!";
                return RedirectToAction("All", "FoodRecipe");
            }

            try
            {
                var model = await this.foodRecipeService.FindFoodRecipeByIdForEditAndDelete(id);

                return View(model);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "You cannot edit this food recipe!";
                return RedirectToAction("All", "FoodRecipe");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(FoodRecipeFormModel model,string id)
        {
            bool isExist = await this.foodRecipeService.IsFoodRecipeExist(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "This food recipe doesn't exist!";
                return RedirectToAction("All", "FoodRecipe");
            }

            try
            {
                await this.foodRecipeService.EditExistingFoodRecipe(model,id);

                TempData[SuccessMessage] = "Your food recipe was edited successfully!";
                return RedirectToAction("All","FoodRecipe");
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Something went wrong try to edit again!";
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            bool isExist = await this.foodRecipeService.IsFoodRecipeExist(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "This food recipe doesn't exist!";
                return RedirectToAction("All", "FoodRecipe");
            }

            string userId = this.User.GetId();
            bool isItTheAuthor = await this.foodRecipeService.IsAuthorIdEqualToUserId(userId, id);
            if (!isItTheAuthor)
            {
                TempData[ErrorMessage] = "Only the author of recipe can delete it!";
                return RedirectToAction("All", "FoodRecipe");
            }

            try
            {
                var model = await this.foodRecipeService.FindFoodRecipeByIdForEditAndDelete(id);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id,FoodRecipeFormModel model)
        {
            bool isExist = await this.foodRecipeService.IsFoodRecipeExist(id);

            if (!isExist)
            {
                TempData[ErrorMessage] = "This food recipe doesn't exist!";
                return RedirectToAction("All", "FoodRecipe");
            }

            string userId = this.User.GetId();
            bool isItTheAuthor = await this.foodRecipeService.IsAuthorIdEqualToUserId(userId, id);
            if (!isItTheAuthor)
            {
                TempData[ErrorMessage] = "Only the author of recipe can delete it!";
                return RedirectToAction("All", "FoodRecipe");
            }

            try
            {
                await this.foodRecipeService.DeleteFoodRecipeByIdAsync(id);

                TempData[WarningMessage] = "You successfuly deleted your food recipe!";
                return RedirectToAction("All","FoodRecipe");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
