using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Services.Data.Interfaces
{
    public interface IProductReviewService
    {
        Task<ICollection<ReviewInDetailViewModel>> GetAllReviewByProductId(string id);

        Task<ICollection<ReviewInDetailViewModel>> FindReviewsByProductId(string productId);

        Task AddReviewToProduct(ReviewFormViewModel model, string productId, string userId);

        Task<bool> IsUserHaveReviewInThisProduct(string userId, string productId);

        Task EditReviewInProduct(ReviewFormViewModel model, string userId, string productId);

        Task DeleteReviewInProduct(string userId, string productId);

        Task<ReviewFormViewModel> FindReviewByUserIdAndProductId(string userId, string productId);
    }
}
