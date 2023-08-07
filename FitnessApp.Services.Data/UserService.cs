using FitnessApp.Data;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.User;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
	public class UserService : IUserService
	{
		private readonly FitnessAppDbContext dbContext;

		public UserService(FitnessAppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<ICollection<UserViewModel>> GetUsers()
		{
			var users = await dbContext.Users
				.Select(u => new UserViewModel()
				{
					Email = u.Email,
					FirstName = u.FirstName,
					LastName = u.LastName,
					UserName = u.UserName
				})
				.ToArrayAsync();

			return users;
		}
	}
}
