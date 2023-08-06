
namespace FitnessApp.Web.Areas.Admin.Services.Interfaces
{
    using FitnessApp.Web.Areas.Admin.ViewModels.Product;
    public interface IAdminProductService
    {
        Task AddProduct(ProductFormModel model);
        Task EditProduct(ProductFormModel model, string id);
        Task MakeUnavailableProduct(string id);
        Task MakeAvailableProduct(string id);
        Task<ProductFormModel> GetProductForEditAndDelete(string id);
    }
}
