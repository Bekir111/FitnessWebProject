using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Services.Data.Interfaces
{
	public interface IProgramReviewService
	{
		Task<ICollection<ReviewInDetailViewModel>> FindReviewsByProgramId(string programId);

		Task AddReviewToProgram(ReviewFormViewModel model, string programId, string userId);

		Task<bool> IsUserHaveReviewInThisProgram(string userId,string programId);

		Task EditReviewInProgram(ReviewFormViewModel model, string userId, string programId);

		Task DeleteReviewInProgram(string userId, string programId);

		Task<ReviewFormViewModel> FindReviewByUserIdAndProgramId(string userId, string programId);

		Task<ReviewInDetailViewModel[]> GetAllReviewsByProgramId(string programId);

    }
}
