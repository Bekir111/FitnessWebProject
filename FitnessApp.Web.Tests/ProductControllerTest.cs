using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.Controllers;
using FitnessApp.Web.ViewModels.Product;
using FitnessApp.Web.ViewModels.Program;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FitnessApp.Web.Tests
{
    public class ProductControllerTest
    {
        private ProductController controller;
        private Mock<IProductService> mockProductService;
        private Mock<IProductReviewService> mockProductReviewService;

        public ProductControllerTest()
        {
            this.mockProductService = new Mock<IProductService>();
            this.mockProductReviewService = new Mock<IProductReviewService>();

            this.controller = new ProductController(mockProductService.Object, mockProductReviewService.Object);
        }
        [Fact]
        public async Task Index_ReturnsCollectionOfPrograms()
        {
            this.mockProductService
                .Setup(service => service.GetAllProducts())
                .ReturnsAsync(new List<ProductAllViewModel>());

            var result = await controller.All() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(typeof(List<ProductAllViewModel>), result.Model.GetType());
        }
    }
}
