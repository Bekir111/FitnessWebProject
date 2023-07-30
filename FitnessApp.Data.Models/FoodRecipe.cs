
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static FitnessApp.Common.EntityValidationConstants.FoodRecipe;
    public class FoodRecipe
    {
        public FoodRecipe()
        {
            this.Id = Guid.NewGuid();
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

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
