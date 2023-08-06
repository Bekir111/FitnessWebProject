
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
                return View(model);
            }

            try
            {
                await this.adminProgramService.AddProgram(model);
                TempData[SuccessMessage] = "You added program successfully";
                return RedirectToAction("All", "Program", new { Area = "" });
            }
            catch (Exception)
            {

                throw;
            }

            return View(model);
        }
    }
}
