using FitnessApp.Web.Areas.Admin.ViewModels.Category;

namespace FitnessApp.Web.Areas.Admin.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<ProgramSelectCategoryFormModel>> AllCategoriesAsync();

        Task<bool> ExistsByIdAsync(int id);

        Task<IEnumerable<string>> AllCategoryNamesAsync();
    }
}
