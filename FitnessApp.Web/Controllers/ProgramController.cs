using FitnessApp.Services.Data.Interfaces;
using FitnessApp.Web.ViewModels.Program;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Web.Controllers
{
    public class ProgramController : BaseController
    {
        private readonly IProgramService programService;

        public ProgramController(IProgramService programService)
        {
            this.programService = programService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllProgramViewModel> programs = await programService.GetAllPrograms();
            return View(programs);
        }

        public async Task<IActionResult> Detail(string id)
        {
            try
            {
                var program = await programService.GetProgramById(id);
                return View(program)

            }
            catch (Exception)
            {
                return RedirectToAction("All", "Program");
            }

        }
    }
}
