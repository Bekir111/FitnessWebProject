namespace FitnessApp.Web.ViewModels.Program
{
	public class AllProgramViewModel
	{
		public string Id { get; set; } = null!;

		public string Name { get; set; } = null!;

		public string PictureUrl { get; set; } = null!;

		public int CategoryId { get; set; }

		public string CategoryName { get; set; } = null!;

		public double AverageRating { get; set; }
	}
}
