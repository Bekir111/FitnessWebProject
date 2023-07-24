using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly IProgramService programService;

        public ProfileController(IProgramService programService)
        {
            this.programService = programService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetPrograms()
        {
            try
            {
                string userId = this.User.GetId();
                var programs = await this.programService.GetProgramsByUserId(userId);

                return PartialView("_ProgramPartial", programs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
