
namespace FitnessApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.FoodRecipe;

    public class FoodRecipeService : IFoodRecipeService
    {
        private readonly FitnessAppDbContext dbContext;

        public FoodRecipeService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddFoodRecipeAsync(FoodRecipeFormModel model, string userId)
        {
            var foodRecipe = new FoodRecipe()
            {
                Name = model.Name,
                Ingredients = model.Ingredients,
                MethodToMake = model.MethodToMake,
                UserId = Guid.Parse(userId),
            };

            await dbContext.FoodRecipes.AddAsync(foodRecipe);

            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<AllFoodRecipeViewModel>> GetAllFoodRecipes()
        {
            return await dbContext.FoodRecipes
                .Select(fr => new AllFoodRecipeViewModel()
                {
                    Id = fr.Id.ToString(),
                    Name = fr.Name,
                    UserName = fr.User.UserName,
                    UserId = fr.UserId.ToString()
                })
                .ToArrayAsync();
        }

        public async Task<DetailFoodRecipeViewModel> GetFoodRecipeByIdForDetail(string id)
        {
            var foodRecipe = await dbContext.FoodRecipes
                .FirstOrDefaultAsync(fr => fr.Id.ToString() == id);

            if (foodRecipe == null)
            {
                throw new InvalidOperationException("The food recipe cannot be found!");
            }


            return new DetailFoodRecipeViewModel()
            {
                Id = foodRecipe.Id.ToString(),
                Ingredients = foodRecipe.Ingredients,
                MethodToMake = foodRecipe.MethodToMake,
                Name = foodRecipe.Name,
                UserId = foodRecipe.UserId.ToString()
            };
        }
    }
}
