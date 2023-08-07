
namespace FitnessApp.Web.Controllers
{
    using System.Data;
    
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Reviews;

    using static FitnessApp.Common.NotificationMessagesConstants;
    using static Common.AdminConstants;

    public class ProductReviewController : BaseController
    {
        private readonly IProductReviewService reviewService;

        public ProductReviewController(IProductReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(string id)
        {
            string userId = this.User.GetId();
            bool isUserHaveReview = await this.reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (isUserHaveReview)
            {
                TempData[ErrorMessage] = "You already had wrote a review!";
                return RedirectToAction("Detail", "Product", new { id = id });
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
            bool isUserHaveReview = await this.reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (isUserHaveReview)
            {
                TempData[ErrorMessage] = "You have already written a review for this product!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }

            try
            {
                await this.reviewService.AddReviewToProduct(model, id, userId);
                TempData[SuccessMessage] = "Review was added successfully!";
                return RedirectToAction("Detail", "Product", new { id = id });

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
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot edit review because you dont have one in this product!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }

            try
            {
                var model = await this.reviewService.FindReviewByUserIdAndProductId(userId, id);
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
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot edit review because you dont have one!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }

            try
            {
                await this.reviewService.EditReviewInProduct(model, userId, id);

                TempData[SuccessMessage] = "You edited your review successfully!";
                return RedirectToAction("Detail", "Product", new { id = id });
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
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot delete review because you dont have one in this product!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }

            try
            {
                var model = await this.reviewService.FindReviewByUserIdAndProductId(userId, id);
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
            bool isUserHaveReview = await reviewService.IsUserHaveReviewInThisProduct(userId, id);
            if (!isUserHaveReview)
            {
                TempData[ErrorMessage] = "You cannot delete review because you dont have one in this product!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }

            try
            {
                await this.reviewService.DeleteReviewInProduct(userId, id);
                TempData[WarningMessage] = "Tour review was deleted successfully!";
                return RedirectToAction("Detail", "Product", new { id = id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }


    }
}
