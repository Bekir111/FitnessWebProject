using FitnessApp.Web.ViewModels.Program;

namespace FitnessApp.Services.Data.Interfaces
{
	public interface IProgramService
	{
		Task<ICollection<AllProgramViewModel>> GetAllPrograms();
	}
}
