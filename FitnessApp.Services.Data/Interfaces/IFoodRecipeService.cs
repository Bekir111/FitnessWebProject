
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.FoodRecipe;
    public interface IFoodRecipeService
    {
        Task<ICollection<AllFoodRecipeViewModel>> GetAllFoodRecipes();

        Task AddFoodRecipeAsync(FoodRecipeFormModel model,string userId);

        Task<DetailFoodRecipeViewModel> GetFoodRecipeByIdForDetail(string id);

        Task<FoodRecipeFormModel> FindFoodRecipeByIdForEditAndDelete(string id);

        Task EditExistingFoodRecipe(FoodRecipeFormModel model,string id);
    }
}
