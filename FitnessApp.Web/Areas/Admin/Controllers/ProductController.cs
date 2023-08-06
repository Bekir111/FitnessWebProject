
namespace FitnessApp.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Areas.Admin.Services.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;
    using FitnessApp.Web.Areas.Admin.ViewModels.Product;

    using static FitnessApp.Common.NotificationMessagesConstants;

    public class ProductController : BaseAdminController
    {
        private readonly IProductService productService;
        private readonly IAdminProductService adminProductService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService, IAdminProductService adminProductService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.adminProductService = adminProductService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ProductFormModel model = new ProductFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Some of the data that you filled are incorrect!";
                return View(model);
            }

            await this.adminProductService.AddProduct(model);
            TempData[SuccessMessage] = "You added product successfully";
            return RedirectToAction("All", "Product", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            var model = await this.adminProductService.GetProductForEditAndDelete(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductFormModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Some of the data that you filled are incorrect!";
                return View(model);
            }
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            await this.adminProductService.EditProduct(model, id);
            TempData[SuccessMessage] = "You edited product successfully";
            return RedirectToAction("All", "Product", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> Available(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            var model = await this.adminProductService.GetProductForEditAndDelete(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Available(ProgramFormModel model, string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            await this.adminProductService.MakeAvailableProduct(id);
            TempData[SuccessMessage] = "You made available product successfully";
            return RedirectToAction("All", "Product", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> Unavailable(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            var model = await this.adminProductService.GetProductForEditAndDelete(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Unavailable(ProgramFormModel model, string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This product doesn't exist!";
                return RedirectToAction("All", "Product", new { Area = "" });
            }

            await this.adminProductService.MakeUnavailableProduct(id);
            TempData[SuccessMessage] = "You made unavailable product successfully";
            return RedirectToAction("All", "Product", new { Area = "" });

        }

    }
}
