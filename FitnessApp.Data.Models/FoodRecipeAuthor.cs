
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    public class FoodRecipeAuthor
    {
        [Required]
        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }
        public ApplicationUser Author { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(FoodRecipe))]
        public Guid FoodRecipeId { get; set; }
        public FoodRecipe FoodRecipe { get; set; } = null!;
    }
}
