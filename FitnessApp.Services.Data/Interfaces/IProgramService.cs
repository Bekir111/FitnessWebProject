namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Program;
    using FitnessApp.Web.ViewModels.Reviews;

    public interface IProgramService
    {
        Task<ICollection<AllProgramViewModel>> GetAllPrograms();

        Task<DetailProgramViewModel> GetProgramById(string id);

        Task<bool> IsProgramExist(string id);

        Task<ICollection<AllProgramViewModel>> GetProgramsByUserId(string id);

        Task JoinTheProgramByIdAndUserId(string programId, string userId);

        Task<bool> IsUserJoinedTheProgram(string programId, string userId);

        Task LeaveTheProgramByIdAndUserId(string programId, string userId);

    }
}
