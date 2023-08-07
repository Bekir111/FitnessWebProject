using FitnessApp.Web.ViewModels.User;

namespace FitnessApp.Services.Data.Interfaces
{
	public interface IUserService
	{
		Task<ICollection<UserViewModel>> GetUsers();
	}
}
