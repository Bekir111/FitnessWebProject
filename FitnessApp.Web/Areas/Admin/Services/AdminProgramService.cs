
namespace FitnessApp.Web.Areas.Admin.Services
{
    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Web.Areas.Admin.Services.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;
    public class AdminProgramService : IAdminProgramService
    {
        private readonly FitnessAppDbContext dbContext;

        public AdminProgramService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddProgram(ProgramFormModel model)
        {
            var program = new FitnessApp.Data.Models.Program()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                Description = model.Description,
                PictureUrl = model.PictureUrl,
            };

            await dbContext.Programs.AddAsync(program);
            await dbContext.SaveChangesAsync();
        }
    }
}
