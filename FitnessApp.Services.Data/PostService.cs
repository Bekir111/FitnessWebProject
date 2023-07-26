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
                    Title = p.Title,
                    CreatedOn = p.CreatedOn.ToString("dd MMMM yyyy")
                })
                .ToArrayAsync();
        }

        public async Task<DetailPostViewModel> GetPostForDetailAsync(int id)
        {
            var post = await this.dbContext.Posts
                .FirstAsync(p => p.Id == id);

            return new DetailPostViewModel()
            {
                Id = post.Id,
                CreatedOn = post.CreatedOn.ToString("dd MMMM yyyy"),
                Text = post.Text,
                Title = post.Title
            };
        }

        public async Task<bool> IsPostExistbyId(int id)
        {
            return await this.dbContext.Posts.AnyAsync(p => p.Id == id);
        }
    }
}
