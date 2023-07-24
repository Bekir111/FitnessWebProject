
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Product;
    public interface IProductService
    {
        Task<ICollection<ProductAllViewModel>> GetAllProducts();
    }
}
