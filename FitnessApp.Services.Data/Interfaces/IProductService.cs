
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Data.Models;
    using FitnessApp.Web.ViewModels.Product;
    public interface IProductService
    {
        Task<ICollection<ProductAllViewModel>> GetAllProducts();

        Task<ProductDetailViewModel> GetProductByIdForDetail(string id);

        Task<bool> IsProductExist(string id);

        Task<CartItem> FindProductById(string id);

    }
}
