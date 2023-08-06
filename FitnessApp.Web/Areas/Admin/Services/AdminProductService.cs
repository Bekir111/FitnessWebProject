
namespace FitnessApp.Web.Areas.Admin.Services
{
    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Web.Areas.Admin.Services.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Product;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;

    public class AdminProductService : IAdminProductService
    {
        private readonly FitnessAppDbContext dbContext;

        public AdminProductService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddProduct(ProductFormModel model)
        {
            var program = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                PictureUrl = model.PictureUrl,
                Price = model.Price
            };

            await dbContext.Products.AddAsync(program);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditProduct(ProductFormModel model, string id)
        {
            var product = await this.dbContext.Products.FindAsync(Guid.Parse(id));
            product.PictureUrl = model.PictureUrl;
            product.Description = model.Description;
            product.Name = model.Name;
            product.Price = model.Price;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ProductFormModel> GetProductForEditAndDelete(string id)
        {
            var product = await this.dbContext.Products.FindAsync(Guid.Parse(id));

            return new ProductFormModel()
            {
                Description = product.Description,
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price
            };
        }

        public async Task MakeAvailableProduct(string id)
        {
            var product = await this.dbContext.Products.FindAsync(Guid.Parse(id));

            product.IsAvailable = true;

            await dbContext.SaveChangesAsync();
        }

        public async Task MakeUnavailableProduct(string id)
        {
            var product = await this.dbContext.Products.FindAsync(Guid.Parse(id));

            product.IsAvailable = false;

            await dbContext.SaveChangesAsync();
        }
    }
}
