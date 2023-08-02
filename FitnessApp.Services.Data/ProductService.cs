
namespace FitnessApp.Services.Data
{
    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Product;
    using Microsoft.EntityFrameworkCore;
    public class ProductService : IProductService
    {
        private readonly FitnessAppDbContext dbContext;

        public ProductService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<CartItem> FindProductById(string id)
        {
            var product = await this.dbContext.Products.FindAsync(Guid.Parse(id));

            return new CartItem()
            {
                ProductId = product.Id.ToString(),
                PictureUrl = product.PictureUrl,
                Price = product.Price,
                ProductName = product.Name,
                Quantity = 1
            };
        }

        public async Task<ICollection<ProductAllViewModel>> GetAllProducts()
        {
            return await this.dbContext.Products
                .Select(p => new ProductAllViewModel()
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    IsAvailable = p.IsAvailable,
                    PictureUrl = p.PictureUrl,
                    Price = p.Price
                })
                .ToArrayAsync();
        }

        public async Task<ProductDetailViewModel> GetProductByIdForDetail(string id)
        {
            var product = await this.dbContext.Products
                .FirstOrDefaultAsync(p => p.Id.ToString() == id);

            if (product == null)
            {
                throw new Exception();
            }

            return new ProductDetailViewModel()
            {
                Id = product.Id.ToString(),
                IsAvailable = product.IsAvailable,
                Description = product.Description,
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price,
            };
                
        }

        public async Task<bool> IsProductExist(string id)
        {
            return await this.dbContext.Products
                .AnyAsync(p => p.Id.ToString() == id);
        }
    }
}
