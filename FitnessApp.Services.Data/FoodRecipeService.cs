
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
                IsActive = true,
            };

            await dbContext.FoodRecipes.AddAsync(foodRecipe);

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteFoodRecipeByIdAsync(string id)
        {
            var foodrecipe = await this.dbContext.FoodRecipes
                .Where(fr => fr.IsActive)
                .FirstAsync(fr => fr.Id.ToString() == id);

            foodrecipe.IsActive = false;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditExistingFoodRecipe(FoodRecipeFormModel model,string id)
        {
            var foodRecipe = await dbContext.FoodRecipes
                .FirstAsync(fr => fr.Id.ToString() == id && fr.IsActive == true);

            foodRecipe.Name = model.Name;
            foodRecipe.MethodToMake = model.MethodToMake;
            foodRecipe.Ingredients = model.Ingredients;

            await dbContext.SaveChangesAsync();
        }

        public async Task<FoodRecipeFormModel> FindFoodRecipeByIdForEditAndDelete(string id)
        {
            var foodRecipe = await dbContext.FoodRecipes
                .FirstAsync(fr => fr.Id.ToString() == id && fr.IsActive != false);

            if (foodRecipe == null)
            {
                throw new Exception();
            }

            return new FoodRecipeFormModel()
            {
                Name = foodRecipe.Name,
                Ingredients = foodRecipe.Ingredients,
                MethodToMake = foodRecipe.MethodToMake
            };
        }

        public async Task<ICollection<AllFoodRecipeViewModel>> GetAllFoodRecipes()
        {
            return await dbContext.FoodRecipes
                .Where(fr => fr.IsActive == true)
                .Select(fr => new AllFoodRecipeViewModel()
                {
                    Id = fr.Id.ToString(),
                    Name = fr.Name,
                    UserName = fr.User.UserName,
                    UserId = fr.UserId.ToString()
                })
                .ToArrayAsync();
        }

        public async Task<ICollection<AllFoodRecipeViewModel>> GetAllFoodRecipesByUserId(string id)
        {
            return await dbContext.FoodRecipes
                .Where(fr => fr.IsActive == true && fr.UserId.ToString() == id)
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
                .FirstAsync(fr => fr.Id.ToString() == id && fr.IsActive != false);

            return new DetailFoodRecipeViewModel()
            {
                Id = foodRecipe.Id.ToString(),
                Ingredients = foodRecipe.Ingredients,
                MethodToMake = foodRecipe.MethodToMake,
                Name = foodRecipe.Name,
                UserId = foodRecipe.UserId.ToString()
            };
        }

        public async Task<bool> IsAuthorIdEqualToUserId(string userId, string foodRecipeId)
        {
            var foodRecipe = await dbContext.FoodRecipes
                .FirstAsync(fr => fr.Id.ToString() == foodRecipeId);

            return foodRecipe.UserId.ToString() == userId;
        }

        public async Task<bool> IsFoodRecipeExist(string id)
        {
            return await this.dbContext.FoodRecipes
                .AnyAsync(fr => fr.Id.ToString() == id && fr.IsActive == true);
        }
    }
}
