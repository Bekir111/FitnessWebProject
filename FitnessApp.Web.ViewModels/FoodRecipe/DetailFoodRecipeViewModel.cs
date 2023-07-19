using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Web.ViewModels.FoodRecipe
{
    public class DetailFoodRecipeViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Ingredients { get; set; } = null!;

        public string MethodToMake { get; set; } = null!;

        public string UserId { get; set; } = null!;
    }
}
