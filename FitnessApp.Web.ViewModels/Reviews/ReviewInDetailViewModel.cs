namespace FitnessApp.Web.ViewModels.Reviews
{
	public class ReviewInDetailViewModel
	{
		public string Id { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public string UserName { get; set; } = null!;

        public int Rating { get; set; }

        public string ReviewText { get; set; } = null!;
    }
}
