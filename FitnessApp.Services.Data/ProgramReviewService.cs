using FitnessApp.Data;
using FitnessApp.Data.Models;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Reviews;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static FitnessApp.Common.EntityValidationConstants;

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

		public async Task<bool> IsUserHaveReviewInThisProgram(string userId,string programId)
		{
			return await this.dbContext.ProgramReviews
				.AnyAsync(r => r.UserId.ToString() == userId && r.ProgramId.ToString() == programId);
		}

		public async Task EditReviewInProgram(ReviewFormViewModel model, string userId,string programId)
		{
			var review = await dbContext.ProgramReviews
				.FirstAsync(r => r.ProgramId.ToString() == programId && r.UserId.ToString() == userId);

			review.ReviewText = model.ReviewText;
			review.Rating = model.Rating;

			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteReviewInProgram(string userId, string programId)
		{
            var review = await dbContext.ProgramReviews
                .FirstAsync(r => r.ProgramId.ToString() == programId && r.UserId.ToString() == userId);

            review.IsActive = false;

			await dbContext.SaveChangesAsync();
        }

		public async Task<ReviewFormViewModel> FindReviewByUserIdAndProgramId(string userId, string programId)
		{
            var review = await dbContext.ProgramReviews
               .FirstAsync(r => r.ProgramId.ToString() == programId && r.UserId.ToString() == userId);

			return new ReviewFormViewModel()
			{
				Rating = review.Rating,
				ReviewText = review.ReviewText,
			};
        }

        public async Task<ReviewInDetailViewModel[]> GetAllReviewsByProgramId(string programId)
		{
            var reviews = await this.dbContext.ProgramReviews
                .Where(pr => pr.ProgramId.ToString() == programId)
                .Select(pr => new ReviewInDetailViewModel()
                {
                    Id = pr.Id.ToString(),
                    UserId = pr.UserId.ToString(),
                    Rating = pr.Rating,
                    ReviewText = pr.ReviewText,
                    UserName = pr.User.UserName,
                })
                .ToArrayAsync();

            return reviews;
        }

		public async Task<bool> IsReviewExisting(string reviewId)
		{
            return await this.dbContext.ProgramReviews
                 .AnyAsync(r => r.Id.ToString() == reviewId && r.IsActive);
        }

		public async Task GetReviewForAdminForDelete(string reviewId)
		{
            var review = await dbContext.ProgramReviews
                .FirstAsync(r => r.Id.ToString() == reviewId && r.IsActive);

            review.IsActive = false;

            await dbContext.SaveChangesAsync();
        }

		public async Task GetReviewForAdminForEdit(ReviewFormViewModel model, string reviewId)
		{
            var review = await dbContext.ProgramReviews
                .FirstAsync(r => r.Id.ToString() == reviewId && r.IsActive);

            review.ReviewText = model.ReviewText;
            review.Rating = model.Rating;

            await dbContext.SaveChangesAsync();
        }

		public async Task<ReviewFormViewModel> FindReviewById(string id)
		{
            var review = await dbContext.ProgramReviews
               .FirstAsync(r => r.Id.ToString() == id && r.IsActive);

            return new ReviewFormViewModel()
            {
                Rating = review.Rating,
                ReviewText = review.ReviewText,
            };
        }
	}
}
