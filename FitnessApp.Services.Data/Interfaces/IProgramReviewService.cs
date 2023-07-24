using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Services.Data.Interfaces
{
	public interface IProgramReviewService
	{
		Task<ICollection<ReviewInDetailViewModel>> FindReviewsByProgramId(string programId);

		Task AddReviewToProgram(ReviewFormViewModel model, string programId, string userId);

		Task<bool> IsUserHaveReview(string userId);

    }
}
