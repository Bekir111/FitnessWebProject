using FitnessApp.Data;
using FitnessApp.Data.Models;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.FoodRecipe;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
	public class FoodRecipeService : IFoodRecipeService
	{
		private readonly FitnessAppDbContext dbContext;

		public FoodRecipeService(FitnessAppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task AddFoodRecipeAsync(FoodRecipeFormModel model,string userId)
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
	}
}
