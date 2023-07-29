using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Services.Data.Interfaces
{
    public interface IProductReviewService
    {
        Task<ICollection<ReviewInDetailViewModel>> GetAllReviewByProductId(string id);
    }
}
