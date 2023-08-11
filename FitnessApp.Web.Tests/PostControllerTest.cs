
namespace FitnessApp.Web.Tests
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Controllers;
    using FitnessApp.Web.ViewModels.Post;
    using FitnessApp.Web.ViewModels.Product;
    
    using Moq;
    public class PostControllerTest
    {
        private PostController controller;
        private Mock<IPostService> mockPostService;

        public PostControllerTest()
        {
            this.mockPostService = new Mock<IPostService>();

            this.controller = new PostController(mockPostService.Object);
        }
        [Fact]
        public async Task Index_ReturnsCollectionOfPosts()
        {
            this.mockPostService
                .Setup(service => service.GetAllPostsAsync())
                .ReturnsAsync(new List<AllPostsViewModel>());

            var result = await controller.All() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(typeof(List<AllPostsViewModel>), result.Model.GetType());
        }
    }
}
