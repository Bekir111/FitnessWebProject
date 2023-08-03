using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly IProgramService programService;
        private readonly IFoodRecipeService foodRecipeService;
        private readonly IPostService postService;

        public ProfileController(IProgramService programService,IFoodRecipeService foodRecipeService, IPostService postService)
        {
            this.programService = programService;
            this.foodRecipeService = foodRecipeService;
            this.postService = postService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                string userId = this.User.GetId();
                var programs = await this.programService.GetProgramsByUserId(userId);

                return View(programs);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> GetPrograms()
        {
            try
            {
                string userId = this.User.GetId();
                var programs = await this.programService.GetProgramsByUserId(userId);

                return View(programs);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> GetFoodRecipes()
        {
            try
            {
                string userId = this.User.GetId();
                var foodRecipes = await this.foodRecipeService.GetAllFoodRecipesByUserId(userId);

                return View(foodRecipes);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> GetPosts()
        {
            try
            {
                string userId = this.User.GetId();
                var posts = await this.postService.GetAllPostsByUserIdAsync(userId);

                return View(posts);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
