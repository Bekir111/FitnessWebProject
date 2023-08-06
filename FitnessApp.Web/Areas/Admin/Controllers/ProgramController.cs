
namespace FitnessApp.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Areas.Admin.Services.Interfaces;
    using FitnessApp.Web.Areas.Admin.ViewModels.Program;
    using static FitnessApp.Common.NotificationMessagesConstants;
    public class ProgramController : BaseAdminController
    {
        private readonly IProgramService programService;
        private readonly IAdminProgramService adminProgramService;
        private readonly ICategoryService categoryService;

        public ProgramController(IProgramService programService, ICategoryService categoryService, IAdminProgramService adminProgramService)
        {
            this.programService = programService;
            this.categoryService = categoryService;
            this.adminProgramService = adminProgramService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ProgramFormModel model = new ProgramFormModel()
            {
                Categories = await categoryService.AllCategoriesAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProgramFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesAsync();
                TempData[ErrorMessage] = "Some of the data that you filled are incorrect!";
                return View(model);
            }

            bool isCategoryExist = await this.categoryService.ExistsByIdAsync(model.CategoryId);
            if (!isCategoryExist)
            {
                model.Categories = await categoryService.AllCategoriesAsync();
                TempData[ErrorMessage] = "This type of category doesnt exist";
                return View(model);
            }

            await this.adminProgramService.AddProgram(model);
            TempData[SuccessMessage] = "You added program successfully";
            return RedirectToAction("All", "Program", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            bool isExist = await this.programService.IsProgramExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This program doesn't exist!";
                return RedirectToAction("All", "Program", new { Area = "" });
            }

            var model = await this.adminProgramService.GetProgramForEditAndDelete(id);
            model.Categories = await categoryService.AllCategoriesAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProgramFormModel model,string id)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.AllCategoriesAsync();
                TempData[ErrorMessage] = "Some of the data that you filled are incorrect!";
                return View(model);
            }

            bool isCategoryExist = await this.categoryService.ExistsByIdAsync(model.CategoryId);
            if (!isCategoryExist)
            {
                model.Categories = await categoryService.AllCategoriesAsync();
                TempData[ErrorMessage] = "This type of category doesnt exist";
                return View(model);
            }

            await this.adminProgramService.EditProgram(model,id);
            TempData[SuccessMessage] = "You edited program successfully";
            return RedirectToAction("All", "Program", new { Area = "" });

        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            bool isExist = await this.programService.IsProgramExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This program doesn't exist!";
                return RedirectToAction("All", "Program", new { Area = "" });
            }

            var model = await this.adminProgramService.GetProgramForEditAndDelete(id);
            model.Categories = await categoryService.AllCategoriesAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProgramFormModel model, string id)
        {
            bool isExist = await this.programService.IsProgramExist(id);
            if (!isExist)
            {
                TempData[ErrorMessage] = "This program doesn't exist!";
                return RedirectToAction("All", "Program", new { Area = "" });
            }

            await this.adminProgramService.DeleteProgram(id);
            TempData[SuccessMessage] = "You deleted program successfully";
            return RedirectToAction("All", "Program", new { Area = "" });

        }
    }
}
