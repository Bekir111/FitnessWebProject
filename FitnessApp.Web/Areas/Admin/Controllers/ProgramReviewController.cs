
namespace FitnessApp.Web.Areas.Admin.Controllers
{
    using System.Data;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Reviews;
    using static FitnessApp.Common.NotificationMessagesConstants;

    public class ProgramReviewController : BaseAdminController
    {
        private readonly IProgramReviewService reviewService;

        public ProgramReviewController(IProgramReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> AdminDelete(string id)
        {
            bool isReviewExist = await this.reviewService.IsReviewExisting(id);
            if (!isReviewExist)
            {
                return NotFound();
            }

            string userId = this.User.GetId();

            var model = await this.reviewService.FindReviewById(id);
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AdminDelete(ReviewFormViewModel model, string id)
        {

            bool isReviewExist = await this.reviewService.IsReviewExisting(id);
            if (!isReviewExist)
            {
                return NotFound();
            }

            string userId = this.User.GetId();

            await this.reviewService.GetReviewForAdminForDelete(id);
            TempData[SuccessMessage] = "You deleted this review successfully!";

            return RedirectToAction("All", "Program", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> AdminEdit(string id)
        {
            bool isReviewExist = await this.reviewService.IsReviewExisting(id);
            if (!isReviewExist)
            {
                return NotFound();
            }

            string userId = this.User.GetId();

            var model = await this.reviewService.FindReviewById(id);
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AdminEdit(ReviewFormViewModel model, string id)
        {
            string userId = this.User.GetId();
            bool isReviewExist = await this.reviewService.IsReviewExisting(id);
            if (!isReviewExist)
            {
                return NotFound();
            }

            await this.reviewService.GetReviewForAdminForEdit(model, id);
            TempData[SuccessMessage] = "You edited this review successfully!";

            return RedirectToAction("All", "Program", new { Area = "" });

        }
    }
}
