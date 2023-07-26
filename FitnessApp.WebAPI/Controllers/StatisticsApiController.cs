
namespace FitnessApp.WebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Http;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data.Models.Statistics;
    using Microsoft.AspNetCore.Cors;

    [Route("api/statistics")]
    [ApiController]
    public class StatisticsApiController : ControllerBase
    {
        private readonly IStatisticsService statisticsService;

        public StatisticsApiController(IStatisticsService statisticsService)
        {
            this.statisticsService = statisticsService;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(StatisticsServiceModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetStatistics()
        {
            try
            {
                StatisticsServiceModel serviceModel = await this.statisticsService.GetTotalOfEachEntity();

                return this.Ok(serviceModel);
            }
            catch (Exception)
            {
                return this.BadRequest();
            }
        }
    }
}
