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

        public async Task<IActionResult> Index()
        {
            try
            {
                string userId = this.User.GetId();
                var programs = await this.programService.GetProgramsByUserId(userId);

                return View(programs);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IActionResult> GetPrograms()
        {
            try
            {
                string userId = this.User.GetId();
                var programs = await this.programService.GetProgramsByUserId(userId);

                return View(programs);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
