
namespace FitnessApp.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data;
    using FitnessApp.Web.ViewModels.Post;
    using static DatabaseSeeder;
    public class PostServiceTest
    {
        private DbContextOptions<FitnessAppDbContext> dbOptions;
        private FitnessAppDbContext dbContext;
        private IPostService postService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<FitnessAppDbContext>()
                .UseInMemoryDatabase("FitnessAppInMemory" + Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new FitnessAppDbContext(this.dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(this.dbContext);

            this.postService = new PostService(this.dbContext);
        }

        [Test]
        public async Task GetAllPostsShouldPass()
        {

            var result = await this.postService.GetAllPostsAsync();


            Assert.IsNotNull(result);
            Assert.AreEqual(this.dbContext.Posts.Count(p => p.IsActive), result.Count);
        }

        [Test]
        public async Task GetAllPostsByUserIdShouldPass()
        {

            var result = await this.postService.GetAllPostsByUserIdAsync(ApplicationUser.Id.ToString());


            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public async Task GetPostDetailById()
        {
            Post.IsActive = true;
            DetailPostViewModel expected = new DetailPostViewModel()
            {
                Id = Post.Id,
                CreatedOn = Post.CreatedOn.ToString("dd MMMM yyyy"),
                Text = Post.Text,
                Title = Post.Title

            };

            var actual = await this.postService.GetPostForDetailAsync(Post.Id);

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Text, actual.Text);
            Assert.AreEqual(expected.Title, actual.Title);
            Assert.AreEqual(expected.CreatedOn, actual.CreatedOn);
        }

        [Test]
        public async Task GetPostFormModelById()
        {
            Post.IsActive = true;
            PostFormModel expected = new PostFormModel()
            {
                Title = Post.Title,
                Text = Post.Text
            };

            var actual = await this.postService.FindPostByIdForEditAndDelete(Post.Id);

            Assert.AreEqual(expected.Title, actual.Title);
            Assert.AreEqual(expected.Text, actual.Text);
        }

        [Test]
        public async Task IsPostExistbyIdShouldReturnTrue()
        {
            Post.IsActive = true;
            bool actual = await this.postService.IsPostExistbyId(Post.Id);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public async Task IsPostExistbyIdShouldReturnFalse()
        {
            bool actual = await this.postService.IsPostExistbyId(NotActivePost.Id);

            Assert.AreEqual(false, actual);
        }


        [Test]
        public async Task IsThisUserAuthorOfThePostShouldReturnTrue()
        {

            bool actual = await this.postService.IsThisUserAuthorOfThePost(ApplicationUser.Id.ToString(), Post.Id);

            Assert.AreEqual(true, actual);
        }

        [Test]
        public async Task IsThisUserAuthorOfThePostShouldReturnFalse()
        {

            bool actual = await this.postService.IsThisUserAuthorOfThePost("ed4b6f55-acf4-453b-a429-08db7eef598b", Post.Id);

            Assert.AreEqual(false, actual);
        }

        [Test]
        public async Task EditPostShouldPass()
        {
            string expectedName = "Hypertrphy1";
            Post.IsActive = true;


            PostFormModel expected = new PostFormModel()
            {
                Text = Post.Text,
                Title = expectedName,
            };


            await this.postService.EditExistingPost(expected, Post.Id);

            Assert.AreEqual(expectedName, Post.Title);

        }

        [Test]
        public async Task AddPostShouldPass()
        {
            string expectedName = "Legs";


            PostFormModel expected = new PostFormModel()
            {
                Text = expectedName,
                Title = Post.Title
            };

            await this.postService.AddPost(expected, ApplicationUser.Id.ToString());

            Assert.AreEqual(3, ApplicationUser.Posts.Count);

        }

        [Test]
        public async Task DeleteFoodRecipeShouldPass()
        {

            await this.postService.DeleteExistingPost(Post.Id);

            Assert.AreEqual(false, Post.IsActive);

        }
    }
}
