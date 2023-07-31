
namespace FitnessApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Post;
    public class PostService : IPostService
    {
        private readonly FitnessAppDbContext dbContext;

        public PostService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPost(PostFormModel model,string userId)
        {
            var post = new Post()
            {
                Text = model.Text,
                Title = model.Title,
                UserId = Guid.Parse(userId),
            };

            await dbContext.Posts.AddAsync(post);
            await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<AllPostsViewModel>> GetAllPostsAsync()
        {
            return await this.dbContext.Posts
                .Where(p => p.IsActive == true)
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
                .FirstAsync(p => p.Id == id && p.IsActive == true);

            return new DetailPostViewModel()
            {
                Id = post.Id,
                CreatedOn = post.CreatedOn.ToString("dd MMMM yyyy"),
                Text = post.Text,
                Title = post.Title
            };
        }

        public async Task<PostFormModel> FindPostByIdForEditAndDelete(int id)
        {
            var post = await this.dbContext.Posts
                .FirstAsync(p => p.Id == id && p.IsActive);

            return new PostFormModel()
            {
                Text = post.Text,
                Title = post.Title
            };
            
        }

        public async Task<bool> IsPostExistbyId(int id)
        {
            return await this.dbContext.Posts.AnyAsync(p => p.Id == id);
        }

        public async Task<bool> IsThisUserAuthorOfThePost(string userId, int postId)
        {
            return await this.dbContext.Posts
                .AnyAsync(p => p.UserId.ToString() == userId && p.Id == postId && p.IsActive);
        }

        public async Task EditExistingPost(PostFormModel model, int id)
        {
            var post = await dbContext.Posts
               .FirstAsync(p => p.Id == id && p.IsActive == true);

            post.Title = model.Title;
            post.Text = model.Text;

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteExistingPost(int id)
        {
            var post = await dbContext.Posts
               .FirstAsync(p => p.Id == id && p.IsActive == true);

            post.IsActive = false;

            await dbContext.SaveChangesAsync();
        }
    }
}
