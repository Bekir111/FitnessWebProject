using FitnessApp.Data;
using FitnessApp.Data.Models;
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

		public async Task<ICollection<ReviewInDetailViewModel>> FindReviewsByProgramId(string programId)
		{
			var reviews = await this.dbContext.ProgramReviews
				.Where(pr => pr.ProgramId.ToString() == programId)
				.Select(pr => new ReviewInDetailViewModel()
				{
					Id = pr.Id.ToString(),
					Rating = pr.Rating,
					ReviewText = pr.ReviewText,
					UserName = pr.User.UserName,
				})
				.ToArrayAsync();

			return reviews;
		}

        public async Task AddReviewToProgram(ReviewFormViewModel model, string programId, string userId)
        {
            var review = new ProgramReview()
            {
                ProgramId = Guid.Parse(programId),
                UserId = Guid.Parse(userId),
                Rating = model.Rating,
                ReviewText = model.ReviewText,
            };

            await dbContext.ProgramReviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }

		public async Task<bool> IsUserHaveReview(string userId)
		{
			return await this.dbContext.ProgramReviews
				.AnyAsync(r => r.UserId.ToString() == userId);
		}
	}
}
