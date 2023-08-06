
namespace FitnessApp.Web.Areas.Admin.Services.Interfaces
{
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;

    public interface IAdminProgramService
    {
        Task AddProgram(ProgramFormModel model);
    }
}
