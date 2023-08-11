
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
        public static Post Post;
        public static Post NotActivePost;
        public static Product Product;
        public static Program Program;
        public static ProgramReview ProgramReview;
        public static ProductReview ProductReview;
        public static Category Category;

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

            Post = new Post()
            {
                Title = "What Is Hypertrophy?",
                Text = "Hypertrophy is an increase in your muscle size. Most of the time, this increase is accomplished through exercises and workouts that incorporate strength training—lifting weights is the most common way to increase hypertrophy.\r\n\r\nThere are two main types of muscle hypertrophy—sarcoplasmic hypertrophy and myofibril hypertrophy. Sarcoplasmic hypertrophy is the physical increase of your muscle and is what most people mean when they refer to hypertrophy training.1 Meanwhile, myofibril hypertrophy is when a muscle becomes more dense and compact. \r\n\r\nIf increasing your muscle size is your goal, your workout routine should be designed to optimize and increase muscle mass. Generally, this means that you should lift weights and gradually increase the volume of your workouts in order to change the size and shape of your muscles.\r\n\r\nGoals of Hypertrophy Training\r\nHypertrophy training is a type of resistance training that involves focusing on specific techniques that will increase your muscle tone, size, and mass. Although everyone has different workout goals, a lot of people pursue hypertrophy training to support their health goals. Others might engage in this type of training to prevent injury, change their appearance, or even to feel a sense of accomplishment.\r\n\r\nDeveloping adequate levels of muscle mass plays an important role in your health and wellness. For example, having low levels of muscle mass is associated with an increased risk of several diseases, including cardiovascular disease. Low muscle mass also can influence the development of cardio-metabolic issues, type 2 diabetes,4 osteoporosis, and even increase the risk of falls.5\r\n\r\nRegardless of your goals, hypertrophy training is a great option for building muscle mass. Research indicates that you can build muscle mass by focusing on mechanical tension—using a heavy weight and performing exercises through a full range of motion for a period of time—and metabolic stress, which is essentially the pump you achieve as a result of working out at a higher intensity with shorter rest periods. In fact, consistently implementing this type of training regimen is essential to getting results.\r\n\r\nBenefits of Hypertrophy Training\r\nBuilding muscle mass through hypertrophy training can benefit your health in a number of ways. In fact, it is so beneficial that the American Heart Association recommends that everyone incorporate muscle strengthening activities at least twice per week into their workout regimen.",
                CreatedOn = DateTime.Parse("2023-07-25 08:40:00.9444068"),
                IsActive = true,
                UserId = ApplicationUser.Id,
            };

            NotActivePost = new Post()
            {
                Title = "Hypertrophy?",
                Text = "Hypertrophy refers to the enlargement of skeletal muscle fibers in response to being recruited to develop increased levels of tension, as seen in resistance training. It is characterized by an increase in the cross-sectional area of individual muscle fibers resulting from an increase in myofibril proteins (myofilaments). There are two types of muscular hypertrophy: myofibrillar, which is an increase in myofibrils, and sarcoplasmic, which is an increase in muscle glycogen storage.0 Hypertrophy is achieved through exercises and workouts that incorporate strength training, and lifting weights is the most common way to increase hypertrophy.2 Hypertrophy is different from strength training, which refers to increasing the ability of a muscle to produce force through lifting heavier weights.",
                CreatedOn = DateTime.Parse("2023-07-25 08:40:00.9444068"),
                IsActive = false,
                UserId = ApplicationUser.Id,
            };

            Category = new Category()
            {
                Name = "Programs for women",
            };

            Product = new Product()
            {
                Name = "Vital Protein Bar",
                Description = "A perfect blend of taste and nutrition! Packed with high-quality proteins, essential vitamins, and minerals, our protein bar is designed to fuel your active lifestyle. Whether it's pre-workout energy or post-workout recovery, our delicious protein bar will keep you going strong.",
                IsAvailable = true,
                PictureUrl = "https://imgs.search.brave.com/UYY0AslZqnXM_Y9jRAdic7n9ZB04crBLWMOWK674GeE/rs:fit:500:0:0/g:ce/aHR0cHM6Ly93d3cu/dml0YWxwcm90ZWlu/cy5jb20vY2RuL3No/b3AvcHJvZHVjdHMv/UERQYXNzZXRzX0pB/X0NCX0JhcnNfMV9D/YXJ0b24uanBnP3Y9/MTY1MzU4ODMwMyZ3/aWR0aD0yNjA",
                Price = 19.99M,
            };

            Program = new Program()
            {
                Name = "Her Fit",
                Description = "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.",
                PictureUrl = "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg",
                CreatedOn = DateTime.Parse("2023-07-10 13:25:34.4307669"),
                CategoryId = Category.Id,
                IsActive = true,
            };

            ProductReview = new ProductReview()
            {
                IsActive = true,
                ProductId = Product.Id,
                UserId = ApplicationUser.Id,
                Rating = 5,
                ReviewText = "Amazing review for product!"
            };

            ProgramReview = new ProgramReview()
            {
                IsActive = true,
                ProgramId = Program.Id,
                UserId = ApplicationUser.Id,
                Rating = 5,
                ReviewText = "Amazing review for program!"
            };


            dbContext.Users.Add(ApplicationUser);
            dbContext.FoodRecipes.AddRange(FoodRecipe,NotActiveFoodRecipe);
            dbContext.Posts.AddRange(Post,NotActivePost);
            dbContext.Categories.Add(Category);
            dbContext.Products.Add(Product);
            dbContext.Programs.Add(Program);
            dbContext.ProductReviews.Add(ProductReview);
            dbContext.ProgramReviews.Add(ProgramReview);
            dbContext.SaveChanges();
        }
    }
}
