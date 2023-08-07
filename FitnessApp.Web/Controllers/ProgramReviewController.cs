
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Reviews;
    using FitnessApp.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    using static Common.AdminConstants;
    using Microsoft.AspNetCore.Authorization;
    using System.Data;

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
            bool isUserHaveReview = await this.reviewService.IsUserHaveReviewInThisProgram(userId, id);
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
            bool isUserHaveReview = await this.reviewService.IsUserHaveReviewInThisProgram(userId, id);
            if (isUserHaveReview)
            {
                TempData[ErrorMessage] = "You have already written a review for this program!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                await this.reviewService.AddReviewToProgram(model, id, userId);
                TempData[SuccessMessage] = "Review was added successfully!";
                return RedirectToAction("Detail", "Program", new { id = id });

            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProgram(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot edit review because you dont have one in this program!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                var model = await this.reviewService.FindReviewByUserIdAndProgramId(userId, id);
                return View(model);

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ReviewFormViewModel model, string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProgram(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot edit review because you dont have one!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                await this.reviewService.EditReviewInProgram(model, userId, id);

                TempData[SuccessMessage] = "You edited your review successfully!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProgram(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot delete review because you dont have one in this program!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                var model = await this.reviewService.FindReviewByUserIdAndProgramId(userId, id);
                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ReviewFormViewModel model, string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProgram(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot delete review because you dont have one in this program!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }

            try
            {
                await this.reviewService.DeleteReviewInProgram(userId, id);
                TempData[WarningMessage] = "Tour review was deleted successfully!";
                return RedirectToAction("Detail", "Program", new { id = id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        
    }
}
