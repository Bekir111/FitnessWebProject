
namespace FitnessApp.Services.Data
{
    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly FitnessAppDbContext dbContext;

        public UserService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> IsUserHaveAnyPost(string userId)
        {
            return await this.dbContext.Users
                .AnyAsync(u => u.Posts.Count > 0);
        }
    }
}
