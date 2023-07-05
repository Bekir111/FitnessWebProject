using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {

        }

        [ForeignKey(nameof(ProgramReview))]
        public Guid? ProgramReviewId { get; set; }
        public virtual ProgramReview ProgramReview { get; set; }

        [ForeignKey(nameof(ProductReview))]
        public Guid? ProductReviewId { get; set; }
        public virtual ProductReview ProductReview { get; set; }
    }
}
