namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.Program;
    using FitnessApp.Web.ViewModels.Reviews;
    using FitnessApp.Web.Infrastructure.Extensions;

    using static FitnessApp.Common.NotificationMessagesConstants;

    public class ProgramController : BaseController
    {
        private readonly IProgramService programService;
        private readonly IProgramReviewService reviewService;

        public ProgramController(IProgramService programService,IProgramReviewService reviewService)
        {
            this.programService = programService;
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<AllProgramViewModel> programs = await programService.GetAllPrograms();
            return View(programs);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(string id)
        {
            bool ifExist = await this.programService.IsProgramExist(id);
            if (!ifExist)
            {
                return NotFound();
            }
            try
            {
                var program = await programService.GetProgramById(id);
                program.Reviews = await this.reviewService.GetAllReviewsByProgramId(id);
                return View(program);

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }


        public async Task<IActionResult> Join(string id)
        {
            bool isExist = await this.programService.IsProgramExist(id);
            if (!isExist)
            {
                return NotFound();
            }

            bool isJoined = await this.programService.IsUserJoinedTheProgram(id, User.GetId());
            if (isJoined)
            {
                TempData[WarningMessage] = "You have already joined this program!";
                return RedirectToAction("All","Program");
            }

            try
            {
                await this.programService.JoinTheProgramByIdAndUserId(id, User.GetId());
                TempData[SuccessMessage] = "You successfully joined the program!";
                return RedirectToAction("All", "Program");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
