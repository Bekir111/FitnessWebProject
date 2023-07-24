
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Reviews;
    using FitnessApp.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;

    public class ProgramReviewController : BaseController
    {
        private readonly IProgramReviewService reviewService;

        public ProgramReviewController(IProgramReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await this.reviewService.IsUserHaveReview(userId);
            if (isUserHaveReview)
            {
                TempData[ErrorMessage] = "You already had wrote a review!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            return View(new ReviewFormViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = this.User.GetId();
            bool isUserHaveReview = await this.reviewService.IsUserHaveReview(userId);
            if (isUserHaveReview)
            {
                TempData[ErrorMessage] = "You have already written a review!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                await this.reviewService.AddReviewToProgram(model, id, userId);
                TempData[SuccessMessage] = "Review added successfully";
                return RedirectToAction("Detail", "Program", new { id = id });

            }
            catch (Exception)
            {
                return GeneralError();
            }

        }
    }
}
