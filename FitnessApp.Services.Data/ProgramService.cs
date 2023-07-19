﻿
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

        public async Task AddReviewToProgram(ReviewFormViewModel model,string programId,string userId)
        {
            var review = new ProgramReview()
            {
                ProgramId = Guid.Parse(programId),
                UserId = Guid.Parse(userId),
                Rating = model.Rating,
                ReviewText = model.ReviewText,
            };

            await dbContext.ProgramReviews.AddAsync(review);
            await dbContext.SaveChangesAsync();
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
                    CategoryName = p.Category.Name,
                    AverageRating = p.AverageRating,
                    
                })
                .ToArrayAsync();

            return programs;
        }

        public async Task<DetailProgramViewModel> GetProgramById(string id)
        {
            var program = await this.dbContext.Programs
                .FirstOrDefaultAsync(p => p.Id.ToString() == id);

            if (program == null)
            {
                throw new InvalidOperationException("The program cannot be found!");
            }

            return new DetailProgramViewModel()
            {
                Id = program.Id.ToString(),
                Description = program.Description,
                AverageRating = program.AverageRating,
                CreatedOn = program.CreatedOn.ToString("dd/mm/yyyy"),
                Name = program.Name,
                Reviews = await GetAllReviewsByProgramId(program.Id.ToString()),
                PictureUrl = program.PictureUrl,
            };
        }




        private async Task<ProgramReviewInDetailViewModel[]> GetAllReviewsByProgramId(string programId)
        {

            var reviews = await this.dbContext.ProgramReviews
                .Where(pr => pr.ProgramId.ToString() == programId)
                .Select(pr => new ProgramReviewInDetailViewModel()
                {
                    Id = pr.Id.ToString(),
                    UserId = pr.UserId.ToString(),
                    Rating = pr.Rating,
                    ReviewText = pr.ReviewText,
                    UserName = pr.User.UserName,
                })
                .ToArrayAsync();

            return reviews;
        }

    }
}