namespace FitnessApp.Web.ViewModels.Reviews
{
	using System.ComponentModel.DataAnnotations;
	using static FitnessApp.Common.EntityValidationConstants.Review;
	public class ReviewFormViewModel
	{
		[Required]
		[StringLength(ReviewTextMaxLength,MinimumLength = ReviewTextMinLength)]
		public string ReviewText { get; set; } = null!;

		[Required]
		[Range(ReviewRatingMinValue,ReviewRatingMaxValue,ErrorMessage ="The rating must be a number between {0} and {1}")]
        public int Rating { get; set; } 
	}
}
