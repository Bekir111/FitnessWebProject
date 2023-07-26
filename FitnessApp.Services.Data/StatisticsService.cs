
namespace FitnessApp.Services.Data
{
    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data.Models.Statistics;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class StatisticsService : IStatisticsService
    {
        private readonly FitnessAppDbContext dbContext;

        public StatisticsService(FitnessAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<StatisticsServiceModel> GetTotalOfEachEntity()
        {
            var programsCount = await this.dbContext.Programs.CountAsync(x => x.IsActive);
            var productsCount = await this.dbContext.Products.CountAsync(x => x.IsAvailable);
            var foodRecipesCount = await this.dbContext.FoodRecipes.CountAsync(x => x.IsActive);
            var usersCount = await this.dbContext.Users.CountAsync();

            return new StatisticsServiceModel()
            {
                TotalUsers = usersCount,
                TotalProducts = productsCount,
                TotalPrograms = programsCount,
                TotalRecipes = foodRecipesCount,
            };
        }
    }
}
