
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Services.Data.Models.Statistics;
    public interface IStatisticsService
    {
        Task<StatisticsServiceModel> GetTotalOfEachEntity();
    }
}
