
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

        public async Task DeleteProgram(string id)
        {
            var program = await this.dbContext.Programs.FindAsync(Guid.Parse(id));

            program.IsActive = false;

            await dbContext.SaveChangesAsync();
        }

        public async Task EditProgram(ProgramFormModel model, string id)
        {
            var program = await this.dbContext.Programs.FindAsync(Guid.Parse(id));
            program.PictureUrl = model.PictureUrl;
            program.Description = model.Description;
            program.Name = model.Name;
            program.CategoryId = model.CategoryId;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ProgramFormModel> GetProgramForEditAndDelete(string id)
        {
            var program = await this.dbContext.Programs.FindAsync(Guid.Parse(id));

            return new ProgramFormModel()
            {
                CategoryId = program.CategoryId,
                Description = program.Description,
                Name = program.Name,
                PictureUrl = program.PictureUrl,
            };
        }
    }
}
