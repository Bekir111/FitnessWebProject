namespace FitnessApp.Web.ViewModels.FoodRecipe
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using static FitnessApp.Common.EntityValidationConstants.FoodRecipe;
    public class FoodRecipeFormModel
    {

        [Required]
        [StringLength(FoodRecipieNameMaxLength,MinimumLength = FoodRecipieNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(FoodRecipieIngredientsMaxLength, MinimumLength = FooodRecipieIngredientsMinLength)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [StringLength(FoodRecipieMethodToMakeMaxLength, MinimumLength = FoodRecipieMethodToMakeMinLength)]
        public string MethodToMake { get; set; } = null!;
    }
}
