
namespace FitnessApp.Services.Data
{
    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Reviews;
    using Microsoft.EntityFrameworkCore;

    public class ProductReviewService : IProductReviewService
    {
        private readonly FitnessAppDbContext dbContext;

        public ProductReviewService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<ReviewInDetailViewModel>> GetAllReviewByProductId(string id)
        {
            return await this.dbContext.ProductReviews
                .Where(pr => pr.ProductId.ToString() == id)
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
    }
}
