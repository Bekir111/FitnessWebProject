
namespace FitnessApp.Services.Data
{
    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Reviews;
    using Microsoft.EntityFrameworkCore;
    using static FitnessApp.Common.EntityValidationConstants;

    public class ProductReviewService : IProductReviewService
    {
        private readonly FitnessAppDbContext dbContext;

        public ProductReviewService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddReviewToProduct(ReviewFormViewModel model, string productId, string userId)
        {
            var review = new ProductReview()
            {
                ProductId = Guid.Parse(productId),
                UserId = Guid.Parse(userId),
                Rating = model.Rating,
                ReviewText = model.ReviewText,
            };

            await dbContext.ProductReviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteReviewInProduct(string userId, string productId)
        {
            var review = await dbContext.ProductReviews
                .FirstAsync(r => r.ProductId.ToString() == productId && r.UserId.ToString() == userId && r.IsActive);

            review.IsActive = false;

            await dbContext.SaveChangesAsync();
        }

        public async Task EditReviewInProduct(ReviewFormViewModel model, string userId, string productId)
        {
            var review = await dbContext.ProductReviews
                .FirstAsync(r => r.ProductId.ToString() == productId && r.UserId.ToString() == userId && r.IsActive);

            review.ReviewText = model.ReviewText;
            review.Rating = model.Rating;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ReviewFormViewModel> FindReviewById(string id)
        {
            var review = await dbContext.ProductReviews
               .FirstAsync(r => r.Id.ToString() == id && r.IsActive);

            return new ReviewFormViewModel()
            {
                Rating = review.Rating,
                ReviewText = review.ReviewText,
            };
        }

        public async Task<ReviewFormViewModel> FindReviewByUserIdAndProductId(string userId, string productId)
        {
            var review = await dbContext.ProductReviews
               .FirstAsync(r => r.ProductId.ToString() == productId && r.UserId.ToString() == userId && r.IsActive);

            return new ReviewFormViewModel()
            {
                Rating = review.Rating,
                ReviewText = review.ReviewText,
            };
        }

        public async Task<ICollection<ReviewInDetailViewModel>> FindReviewsByProductId(string productId)
        {
            var reviews = await this.dbContext.ProductReviews
                .Where(pr => pr.ProductId.ToString() == productId && pr.IsActive)
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

        public async Task<ICollection<ReviewInDetailViewModel>> GetAllReviewByProductId(string id)
        {
            return await this.dbContext.ProductReviews
                .Where(pr => pr.ProductId.ToString() == id && pr.IsActive)
                .Select(pr => new ReviewInDetailViewModel()
                {
                    Id = pr.Id.ToString(),
                    Rating = pr.Rating,
                    ReviewText = pr.ReviewText,
                    UserId = pr.UserId.ToString(),
                    UserName = pr.User.UserName,
                })
                .ToArrayAsync();
        }

        public async Task ReviewForAdminForDelete(string reviewId)
        {
            var review = await dbContext.ProductReviews
                .FirstAsync(r => r.Id.ToString() == reviewId && r.IsActive);

            review.IsActive = false;

            await dbContext.SaveChangesAsync();
        }

        public async Task ReviewForAdminForEdit(ReviewFormViewModel model, string reviewId)
        {
            var review = await dbContext.ProductReviews
                .FirstAsync(r => r.Id.ToString() == reviewId && r.IsActive);

            review.ReviewText = model.ReviewText;
            review.Rating = model.Rating;

            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsReviewExisting(string reviewId)
        {
            return await this.dbContext.ProductReviews
                 .AnyAsync(r => r.Id.ToString() == reviewId && r.IsActive);
        }

        public async Task<bool> IsUserHaveReviewInThisProduct(string userId, string productId)
        {
            return await this.dbContext.ProductReviews
                .AnyAsync(r => r.UserId.ToString() == userId && r.ProductId.ToString() == productId && r.IsActive);
        }
    }
}
