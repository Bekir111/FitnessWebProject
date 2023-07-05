
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static FitnessApp.Common.EntityValidationConstants.FoodRecipe;
    public class FoodRecipe
    {
        public FoodRecipe()
        {
            this.Id = Guid.NewGuid();
            this.FoodRecipeAuthors = new HashSet<FoodRecipeAuthor>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FoodRecipieNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(FoodRecipieIngredientsMaxLength)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [MaxLength(FoodRecipieMethodToMakeMaxLength)]
        public string MethodToMake { get; set; } = null!;

        public virtual ICollection<FoodRecipeAuthor> FoodRecipeAuthors { get; set; } = null!;
    }
}
