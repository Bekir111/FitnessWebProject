
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static FitnessApp.Common.EntityValidationConstants.Post;
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(PostTitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(PostTextMaxLength)]
        public string Text { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;


    }
}
