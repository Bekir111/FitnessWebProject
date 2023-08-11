
namespace FitnessApp.Services.Tests
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data;
    using static DatabaseSeeder;
    using FitnessApp.Web.ViewModels.Post;
    using FitnessApp.Web.ViewModels.Product;
    using FitnessApp.Web.ViewModels.Cart;
    using FitnessApp.Web.ViewModels;

    public class ProductServiceTest
    {
        private DbContextOptions<FitnessAppDbContext> dbOptions;
        private FitnessAppDbContext dbContext;
        private IProductService productService;
        private IProductReviewService productReviewService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<FitnessAppDbContext>()
                .UseInMemoryDatabase("FitnessAppInMemory" + Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new FitnessAppDbContext(this.dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(this.dbContext);

            this.productService = new ProductService(this.dbContext);
            this.productReviewService = new ProductReviewService(this.dbContext);
        }

        [Test]
        public async Task GetAllProductsShouldPass()
        {

            var result = await this.productService.GetAllProducts();


            Assert.IsNotNull(result);
            Assert.AreEqual(this.dbContext.Products.Count(), result.Count);
        }

        [Test]
        public async Task GetProductDetailById()
        {
            DatabaseSeeder.Product.IsAvailable = true;


            ProductDetailViewModel expected = new ProductDetailViewModel()
            {
                Id = DatabaseSeeder.Product.Id.ToString(),
                Description = DatabaseSeeder.Product.Description,
                Name = DatabaseSeeder.Product.Name,
                Price = DatabaseSeeder.Product.Price,
                PictureUrl = DatabaseSeeder.Product.PictureUrl,

            };

            var actual = await this.productService.GetProductByIdForDetail(DatabaseSeeder.Product.Id.ToString());

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.PictureUrl, actual.PictureUrl);
        }

        [Test]
        public async Task IsPorductExistShouldReturnTrue()
        {
            DatabaseSeeder.Product.IsAvailable = true;

            var actual = await this.productService.IsProductExist(DatabaseSeeder.Product.Id.ToString());

            Assert.AreEqual(true, actual);
        }

        [Test]
        public async Task IsPorductExistShouldReturnFalse()
        {
            DatabaseSeeder.Product.IsAvailable = false;

            var actual = await this.productService.IsProductExist(DatabaseSeeder.Program.Id.ToString());

            Assert.AreEqual(false, actual);
        }

        [Test]
        public async Task FindProductbyIdShouldPass()
        {
            Product.IsAvailable = true;

            CartItem expected = new CartItem()
            {
                PictureUrl = Product.PictureUrl,
                ProductId = Product.Id.ToString(),
                Price = Product.Price,
                ProductName = Product.Name,
                Quantity = 1
            };

            var actual = await this.productService.FindProductById(Product.Id.ToString());

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.PictureUrl, actual.PictureUrl);
            Assert.AreEqual(expected.Quantity, actual.Quantity);
        }
    }
}
