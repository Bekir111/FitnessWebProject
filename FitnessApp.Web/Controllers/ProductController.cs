
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using static FitnessApp.Common.NotificationMessagesConstants;
    public class ProductController : BaseController
    {
        private readonly IProductService productService;
        private readonly IProductReviewService reviewService;

        public ProductController(IProductService productService , IProductReviewService reviewService)
        {
            this.productService = productService;
            this.reviewService = reviewService;
        }

        public async Task<IActionResult> All()
        {
            var products = await this.productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                return View("Error404");
            }

            try
            {
                var product = await this.productService.GetProductByIdForDetail(id);
                product.Reviews = await this.reviewService.GetAllReviewByProductId(id);
                return View(product);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }

        }
    }
}
