
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static FitnessApp.Common.EntityValidationConstants.Review;
    public class ProgramReview
    {
        public ProgramReview()
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
        [ForeignKey(nameof(Program))]
        public Guid ProgramId { get; set; }
        public Program Program { get; set; } = null!;

        [Required]
        [Range(ReviewRatingMinValue,ReviewRatingMaxValue)]
        public int Rating { get; set; }

        [Required]
        [MaxLength(ReviewTextMaxLength)]
        public string ReviewText { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
