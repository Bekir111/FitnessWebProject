
namespace FitnessApp.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Program;
    using FitnessApp.Web.ViewModels.Reviews;
    using FitnessApp.Data.Models;

    public class ProgramService : IProgramService
    {
        private readonly FitnessAppDbContext dbContext;

        public ProgramService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<AllProgramViewModel>> GetAllPrograms()
        {
            var programs = await this.dbContext.Programs
                .Where(p => p.IsActive)
                .Select(p => new AllProgramViewModel()
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    PictureUrl = p.PictureUrl,
                    CategoryId = p.CategoryId,
                    CategoryName = p.Category.Name,
                    AverageRating = p.Reviews.Count == 0 ? "0.0" : p.Reviews.Where(r => r.IsActive).Average(p => p.Rating).ToString("f1")

                })
                .ToArrayAsync();

            return programs;
        }

        public async Task<DetailProgramViewModel> GetProgramById(string id)
        {
            var program = await this.dbContext.Programs
                .FirstOrDefaultAsync(p => p.Id.ToString() == id && p.IsActive);

            return new DetailProgramViewModel()
            {
                Id = program.Id.ToString(),
                Description = program.Description,
                AverageRating = program.AverageRating,
                CreatedOn = program.CreatedOn.ToString("dd/mm/yyyy"),
                Name = program.Name,
                PictureUrl = program.PictureUrl,
            };
        }

        public async Task<ICollection<AllProgramViewModel>> GetProgramsByUserId(string id)
        {
            return await this.dbContext.ProgramUsers
                .Where(pu => pu.UserId.ToString() == id && pu.IsActive)
                .Select(pu => new AllProgramViewModel()
                {
                    Id = pu.ProgramId.ToString(),
                    CategoryId = pu.Program.CategoryId,
                    CategoryName = pu.Program.Category.Name,
                    Name = pu.Program.Name,
                    PictureUrl = pu.Program.PictureUrl,
                    AverageRating = pu.Program.Reviews.Count == 0 ? "0.0" : pu.Program.Reviews.Where(r => r.IsActive).Average(p => p.Rating).ToString("f1")
                })
                .ToArrayAsync();
        }

        public async Task<bool> IsProgramExist(string id)
        {
            return await dbContext.Programs.AnyAsync(p => p.Id.ToString() == id && p.IsActive);
        }

        public async Task<bool> IsUserJoinedTheProgram(string programId, string userId)
        {
            return await this.dbContext.ProgramUsers
                .AnyAsync(pu => pu.ProgramId.ToString() == programId && pu.UserId.ToString() == userId && pu.IsActive);
        }

        public async Task JoinTheProgramByIdAndUserId(string programId, string userId)
        {
            var programUser = new ProgramUser()
            {
                ProgramId = Guid.Parse(programId),
                UserId = Guid.Parse(userId)
            };

            await this.dbContext.ProgramUsers.AddAsync(programUser);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task LeaveTheProgramByIdAndUserId(string programId, string userId)
        {
            var programUser = await this.dbContext.ProgramUsers
                .FirstAsync(pu => pu.UserId.ToString() == userId && pu.ProgramId.ToString() == programId && pu.IsActive);

            programUser.IsActive = false;

            await dbContext.SaveChangesAsync();
        }
    }
}