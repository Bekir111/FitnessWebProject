
namespace FitnessApp.Web.ViewModels.Post
{
    using System.ComponentModel.DataAnnotations;

    using static FitnessApp.Common.EntityValidationConstants.Post;
    public class PostFormModel
    {
        [Required]
        [StringLength(PostTitleMaxLength,MinimumLength = PostTitleMinLength, ErrorMessage = "The posts title length must be between {0} and {1}")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(PostTextMaxLength,MinimumLength = PostTextMinLength, ErrorMessage = "The posts text length must be between {0} and {1}")]
        public string Text { get; set; } = null!;
    }
}
