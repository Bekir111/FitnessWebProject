namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Program;
    using FitnessApp.Web.ViewModels.Reviews;
    using FitnessApp.Web.Infrastructure.Extensions;

    public class ProgramController : BaseController
    {
        private readonly IProgramService programService;
        private readonly IProgramReviewService reviewService;

        public ProgramController(IProgramService programService,IProgramReviewService reviewService)
        {
            this.programService = programService;
            this.reviewService = reviewService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllProgramViewModel> programs = await programService.GetAllPrograms();
            return View(programs);
        }

        public async Task<IActionResult> Detail(string id)
        {
            try
            {
                var program = await programService.GetProgramById(id);
                program.Reviews = await this.reviewService.GetAllReviewsByProgramId(id);
                return View(program);

            }
            catch (Exception)
            {
                return NotFound();
            }

        }
    }
}
