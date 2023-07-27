
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static FitnessApp.Common.EntityValidationConstants.ApplicationUser;
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();

            this.ProgramReviews = new HashSet<ProgramReview>();
            this.ProductReviews = new HashSet<ProductReview>();
            this.FoodRecipes = new HashSet<FoodRecipe>();
            this.Posts = new HashSet<Post>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        public virtual ICollection<ProgramReview> ProgramReviews { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        public virtual ICollection<FoodRecipe> FoodRecipes { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
