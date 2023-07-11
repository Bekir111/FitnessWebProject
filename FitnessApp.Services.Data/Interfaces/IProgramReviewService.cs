using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Services.Data.Interfaces
{
	public interface IProgramReviewService
	{
		Task<ICollection<ProgramReviewInDetailViewModel>> FindReviewsByProgramId(string programId);
	}
}
