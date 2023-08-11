using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.Controllers;
using FitnessApp.Web.ViewModels.FoodRecipe;
using FitnessApp.Web.ViewModels.Product;
using FitnessApp.Web.ViewModels.Program;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FitnessApp.Web.Tests
{
    public class FoodRecipeControllerTest
    {
        private FoodRecipeController controller;
        private Mock<IFoodRecipeService> mockFoodRecipeService;

        public FoodRecipeControllerTest()
        {
            this.mockFoodRecipeService = new Mock<IFoodRecipeService>();

            this.controller = new FoodRecipeController(mockFoodRecipeService.Object);
        }
        [Fact]
        public async Task Index_ReturnsCollectionOfFoodRecipes()
        {
            this.mockFoodRecipeService
                .Setup(service => service.GetAllFoodRecipes())
                .ReturnsAsync(new List<AllFoodRecipeViewModel>());

            var result = await controller.All() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal(typeof(List<AllFoodRecipeViewModel>), result.Model.GetType());
        }
    }
}
