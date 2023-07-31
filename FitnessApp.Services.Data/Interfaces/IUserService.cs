namespace FitnessApp.Services.Data.Interfaces
{
	public interface IUserService
	{
		Task<bool> IsUserHaveAnyPost(string userId);
	}
}
