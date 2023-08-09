
namespace FitnessApp.Services.Tests
{

    using Microsoft.EntityFrameworkCore;

    using NUnit.Framework;

    using FitnessApp.Data;

    using static DatabaseSeeder;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data;
    using FitnessApp.Web.ViewModels.FoodRecipe;

    public class FoodRecipeServiceTest
    {
        private DbContextOptions<FitnessAppDbContext> dbOptions;
        private FitnessAppDbContext dbContext;
        private IFoodRecipeService foodRecipeService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<FitnessAppDbContext>()
                .UseInMemoryDatabase("FitnessAppInMemory" + Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new FitnessAppDbContext(this.dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(this.dbContext);

            this.foodRecipeService = new FoodRecipeService(this.dbContext);
        }

        [Test]
        public async Task GetAllFoodRecipesShouldPass()
        {

            var result = await this.foodRecipeService.GetAllFoodRecipes();


            Assert.IsNotNull(result);
            Assert.AreEqual(this.dbContext.FoodRecipes.Count(fr => fr.IsActive), result.Count);
        }

        [Test]
        public async Task GetAllFoodRecipesByUserIdShouldPass()
        {

            var result = await this.foodRecipeService.GetAllFoodRecipesByUserId(ApplicationUser.Id.ToString());


            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public async Task GetFoodRecipeDetailById()
        {
            FoodRecipe.IsActive = true;
            DetailFoodRecipeViewModel expected = new DetailFoodRecipeViewModel()
            {
                Id = FoodRecipe.Id.ToString(),
                Ingredients = FoodRecipe.Ingredients,
                MethodToMake = FoodRecipe.MethodToMake,
                Name = FoodRecipe.Name,
                UserId = FoodRecipe.UserId.ToString()
            };

            var actual = await this.foodRecipeService.GetFoodRecipeByIdForDetail(FoodRecipe.Id.ToString());

            Assert.AreEqual(expected.Id.ToString(), actual.Id.ToString());
            Assert.AreEqual(expected.Ingredients, actual.Ingredients);
            Assert.AreEqual(expected.MethodToMake, actual.MethodToMake);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.UserId.ToString(), actual.UserId.ToString());
        }

        [Test]
        public async Task GetFoodRecipeFormModelById()
        {
            FoodRecipe.IsActive = true;
            FoodRecipeFormModel expected = new FoodRecipeFormModel()
            {
                Name = FoodRecipe.Name,
                Ingredients = FoodRecipe.Ingredients,
                MethodToMake = FoodRecipe.MethodToMake
            };

            var actual = await this.foodRecipeService.FindFoodRecipeByIdForEditAndDelete(FoodRecipe.Id.ToString());

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Ingredients, actual.Ingredients);
            Assert.AreEqual(expected.MethodToMake, actual.MethodToMake);
        }

        [Test]
        public async Task IsFoodRecipeExistShouldReturnTrue()
        {
            FoodRecipe.IsActive = true;

            bool actual = await this.foodRecipeService.IsFoodRecipeExist(FoodRecipe.Id.ToString());

            Assert.AreEqual(true, actual);
        }

        [Test]
        public async Task IsFoodRecipeExistShouldReturnFalse()
        {

            bool actual = await this.foodRecipeService.IsFoodRecipeExist(NotActiveFoodRecipe.Id.ToString());

            Assert.AreEqual(false, actual);
        }


        [Test]
        public async Task IsAuthorIdEqualToUserIdShouldReturnTrue()
        {

            bool actual = await this.foodRecipeService.IsAuthorIdEqualToUserId(ApplicationUser.Id.ToString(),FoodRecipe.Id.ToString());

            Assert.AreEqual(true, actual);
        }

        [Test]
        public async Task IsAuthorIdEqualToUserIdShouldReturnFalse()
        {

            bool actual = await this.foodRecipeService.IsAuthorIdEqualToUserId("ed4b6f55-acf4-453b-a429-08db7eef598b",FoodRecipe.Id.ToString());

            Assert.AreEqual(false, actual);
        }

        [Test]
        public async Task EditFoodRecipeShouldPass()
        {
            string expectedName = "Ground Beef & Cauliflower1";
            FoodRecipe.IsActive = true;


            FoodRecipeFormModel expected = new FoodRecipeFormModel()
            {
                Name = expectedName,
                Ingredients = FoodRecipe.Ingredients,
                MethodToMake = FoodRecipe.MethodToMake
            };


            await this.foodRecipeService.EditExistingFoodRecipe(expected,FoodRecipe.Id.ToString());

            Assert.AreEqual(expectedName, FoodRecipe.Name);

        }

        [Test]
        public async Task AddFoodRecipeShouldPass()
        {
            string expectedName = "Ground Beef & Cauliflower1";


            FoodRecipeFormModel expected = new FoodRecipeFormModel()
            {
                Name = FoodRecipe.Name + "12",
                Ingredients = FoodRecipe.Ingredients,
                MethodToMake = FoodRecipe.MethodToMake
            };

            await this.foodRecipeService.AddFoodRecipeAsync(expected, ApplicationUser.Id.ToString());

            Assert.AreEqual(3, ApplicationUser.FoodRecipes.Count);

        }

        [Test]
        public async Task DeleteFoodRecipeShouldPass()
        {

            await this.foodRecipeService.DeleteFoodRecipeByIdAsync(FoodRecipe.Id.ToString());

            Assert.AreEqual(false, FoodRecipe.IsActive);

        }
    }
}
