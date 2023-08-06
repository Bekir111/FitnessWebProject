
namespace FitnessApp.Web.Areas.Admin.Services.Interfaces
{
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;

    public interface IAdminProgramService
    {
        Task AddProgram(ProgramFormModel model);
        Task EditProgram(ProgramFormModel model,string id);
        Task DeleteProgram(string id);
        Task<ProgramFormModel> GetProgramForEditAndDelete(string id);
    }
}
