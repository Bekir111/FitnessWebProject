using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.ProgramReviews = new HashSet<ProgramReview>();
            this.ProductReviews = new HashSet<ProductReview>();
            this.FoodRecipes = new HashSet<FoodRecipe>();
            this.Posts = new HashSet<Post>();
        }

        public virtual ICollection<ProgramReview> ProgramReviews { get; set; }

        public virtual ICollection<ProductReview>  ProductReviews { get; set;}

        public virtual ICollection<FoodRecipe> FoodRecipes { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
