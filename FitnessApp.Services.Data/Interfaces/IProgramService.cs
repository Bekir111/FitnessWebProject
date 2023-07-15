namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Program;
    using FitnessApp.Web.ViewModels.Reviews;

    public interface IProgramService
    {
        Task<ICollection<AllProgramViewModel>> GetAllPrograms();

        Task<DetailProgramViewModel> GetProgramById(string id);

        Task AddReviewToProgram(ReviewFormViewModel model,string programId,string userId);
    }
}
