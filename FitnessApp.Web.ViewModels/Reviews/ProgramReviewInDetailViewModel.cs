namespace FitnessApp.Web.ViewModels.Reviews
{
	public class ProgramReviewInDetailViewModel
	{
		public string Id { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public int Rating { get; set; }

        public string ReviewText { get; set; } = null!;
        //[Key]
        //public Guid Id { get; set; }

        //[Required]
        //[ForeignKey(nameof(User))]
        //public Guid UserId { get; set; }
        //public ApplicationUser User { get; set; } = null!;

        //[Required]
        //[ForeignKey(nameof(Program))]
        //public Guid ProgramId { get; set; }
        //public Program Program { get; set; } = null!;

        //[Required]
        //[Range(ReviewRatingMinValue, ReviewRatingMaxValue)]
        //public int Rating { get; set; }

        //[Required]
        //[MaxLength(ReviewTextMaxLength)]
        //public string ReviewText { get; set; } = null!;
    }
}
