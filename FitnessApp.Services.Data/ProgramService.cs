using FitnessApp.Data;
using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Program;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Services.Data
{
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
				.Select(p => new AllProgramViewModel()
				{
					Id = p.Id.ToString(),
					Name = p.Name,
					PictureUrl = p.PictureUrl,
					CategoryId = p.CategoryId,
					CategoryName = p.Category.Name
				})
				.OrderByDescending(p => p.CategoryId)
				.ToArrayAsync();

			return programs;
		}
	}
}