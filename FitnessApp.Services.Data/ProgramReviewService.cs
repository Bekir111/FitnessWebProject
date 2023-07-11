using FitnessApp.Data;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Reviews;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
	public class ProgramReviewService : IProgramReviewService
	{
		private readonly FitnessAppDbContext dbContext;

		public ProgramReviewService(FitnessAppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<ICollection<ProgramReviewInDetailViewModel>> FindReviewsByProgramId(string programId)
		{
			var reviews = await this.dbContext.ProgramReviews
				.Where(pr => pr.ProgramId.ToString() == programId)
				.Select(pr => new ProgramReviewInDetailViewModel()
				{
					Id = pr.Id.ToString(),
					Rating = pr.Rating,
					ReviewText = pr.ReviewText,
					UserName = pr.User.UserName,
				})
				.ToArrayAsync();

			return reviews;
		}
	}
}
