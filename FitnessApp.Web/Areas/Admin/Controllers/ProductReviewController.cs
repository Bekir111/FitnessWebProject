
namespace FitnessApp.Web.Areas.Admin.Controllers
{
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Reviews;

    using static FitnessApp.Common.GeneralApplicationConstants;
    using static FitnessApp.Common.NotificationMessagesConstants;
    using FitnessApp.Services.Data.Interfaces;

    public class ProductReviewController : BaseAdminController
    {
        private readonly IProductReviewService reviewService;

        public ProductReviewController(IProductReviewService reviewService)
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

            await this.reviewService.ReviewForAdminForDelete(id);
            TempData[SuccessMessage] = "You deleted this review successfully!";

            return RedirectToAction("All", "Product", new { Area = "" });

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
            bool isReviewExist = await this.reviewService.IsReviewExisting(id);
            if (!isReviewExist)
            {
                return NotFound();
            }

            string userId = this.User.GetId();

            await this.reviewService.ReviewForAdminForEdit(model, id);
            TempData[SuccessMessage] = "You edited this review successfully!";

            return RedirectToAction("All", "Product", new { Area = "" });
        }
    }
}
