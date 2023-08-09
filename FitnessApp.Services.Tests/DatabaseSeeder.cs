
namespace FitnessApp.Services.Tests
{
    using FitnessApp.Data;
    using FitnessApp.Data.Migrations;
    using FitnessApp.Data.Models;
    using System.Runtime.CompilerServices;

    public static class DatabaseSeeder
    {
        public static ApplicationUser ApplicationUser;
        public static FoodRecipe FoodRecipe;
        public static FoodRecipe NotActiveFoodRecipe;

        public static void SeedDatabase(FitnessAppDbContext dbContext)
        {

            ApplicationUser = new ApplicationUser()
            {
                UserName = "Eminem1",
                NormalizedUserName = "EMINEM1",
                Email = "eminem@gmail.com",
                NormalizedEmail = "EMINEM@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "a8c45fb7-6855-412f-bb0a-fee4ecb27f88",
                ConcurrencyStamp = "9d5467bf-6e77-4e4b-afad-f3db42f2caa3",
                TwoFactorEnabled = false,
                FirstName = "Slim",
                LastName = "Shady"
            };

            FoodRecipe = new FoodRecipe()
            {
                Name = "Ground Beef & Cauliflower",
                Ingredients = "1 tablespoon extra-virgin olive oil\r\n½ cup chopped onion\r\n1 medium green bell pepper, chopped\r\n1 pound lean ground beef\r\n3 cups bite-size cauliflower florets\r\n3 cloves garlic, minced\r\n2 tablespoons chili powder\r\n2 teaspoons ground cumin\r\n1 teaspoon dried oregano\r\n½ teaspoon salt\r\n¼ teaspoon ground c",
                MethodToMake = "Remove lemon peel in wide strips with a vegetable peeler, avoiding white pith. Finely chop strips to equal 1 tablespoon; transfer to a medium bowl. Squeeze lemons to equal 3½ tablespoons juice. Add beans, 3 tablespoons oil, ¾ teaspoon salt, and 2 tablespoons lemon juice to chopped lemon peel in bowl.\r\n\r\nPlace garlic, crushed red pepper, 2 tablespoons butter, and remaining 2 tablespoons oil in a large skillet. Cook over medium, stirring often, until garlic is lightly golden, about 4 minutes. Add wine and cook until reduced by half, about 1 minute.",
                UserId = ApplicationUser.Id,
                IsActive = true,
            };

            NotActiveFoodRecipe = new FoodRecipe()
            {
                Name = "Buttery Shrimp With Marinated Beans",
                Ingredients = "2 large lemons\r\n\r\n2 15-oz. cans cannellini beans, drained and rinsed\r\n\r\n5 tablespoons olive oil, divided\r\n\r\n1 ¼ teaspoons kosher salt, divided\r\n\r\n4 large cloves garlic, finely chopped (about 2 Tbsp.)",
                MethodToMake = "Remove lemon peel in wide strips with a vegetable peeler, avoiding white pith. Finely chop strips to equal 1 tablespoon; transfer to a medium bowl. Squeeze lemons to equal 3½ tablespoons juice. Add beans, 3 tablespoons oil, ¾ teaspoon salt, and 2 tablespoons lemon juice to chopped lemon peel in bowl.\r\n\r\nPlace garlic, crushed red pepper, 2 tablespoons butter, and remaining 2 tablespoons oil in a large skillet. Cook over medium, stirring often, until garlic is lightly golden, about 4 minutes. Add wine and cook until reduced by half, about 1 minute.",
                UserId = ApplicationUser.Id,
                IsActive = false,
            };

            dbContext.Users.Add(ApplicationUser);
            dbContext.FoodRecipes.AddRange(FoodRecipe,NotActiveFoodRecipe);
            dbContext.SaveChanges();
        }
    }
}
