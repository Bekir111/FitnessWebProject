
namespace FitnessApp.Web.Areas.Admin.Services
{
    using FitnessApp.Data;
    using FitnessApp.Web.Areas.Admin.Services.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Category;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CategoryService : ICategoryService
    {
        private readonly FitnessAppDbContext dbContext;

        public CategoryService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ProgramSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<ProgramSelectCategoryFormModel> allCategories = await dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new ProgramSelectCategoryFormModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task<IEnumerable<string>> AllCategoryNamesAsync()
        {
            IEnumerable<string> allNames = await dbContext
               .Categories
               .Select(c => c.Name)
               .ToArrayAsync();

            return allNames;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {

            return await dbContext.Categories
                .AnyAsync(c => c.Id == id);
        }
    }
}
