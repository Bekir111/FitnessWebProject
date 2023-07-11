namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Program;
    public interface IProgramService
    {
        Task<ICollection<AllProgramViewModel>> GetAllPrograms();

        Task<DetailProgramViewModel> GetProgramById(string id);
    }
}
