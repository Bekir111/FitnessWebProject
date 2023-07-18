
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.FoodRecipe;
    public interface IFoodRecipeService
    {
        Task<ICollection<AllFoodRecipeViewModel>> GetAllFoodRecipes();

        Task AddFoodRecipeAsync(FoodRecipeFormModel model,string userId);
    }
}
