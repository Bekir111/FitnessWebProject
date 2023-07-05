
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;

    using static FitnessApp.Common.EntityValidationConstants.Review;
    public class ProductReview
    {
        public ProductReview()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Required]
        [Range(ReviewRatingMinValue, ReviewRatingMaxValue)]
        public int Rating { get; set; }

        [Required]
        [MaxLength(ReviewTextMaxLength)]
        public string ReviewText { get; set; } = null!;
    }
}
