using FitnessApp.Data;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Post;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
    public class PostService : IPostService
    {
        private readonly FitnessAppDbContext dbContext;

        public PostService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<AllPostsViewModel>> GetAllPostsAsync()
        {
            return await this.dbContext.Posts
                .Select(p => new AllPostsViewModel()
                {
                    Id = p.Id,
                    Title = p.Title
                })
                .ToArrayAsync();
        }
    }
}
