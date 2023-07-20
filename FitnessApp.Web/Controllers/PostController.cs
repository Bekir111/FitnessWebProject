
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    public class PostController : BaseController
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }
        public async Task<IActionResult> All()
        {
            var posts = await this.postService.GetAllPostsAsync();
            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            try
            {
                var model = await this.postService.GetPostForDetailAsync(id);

                return View(model);
            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "This post doesnt exist";
                return RedirectToAction("All","Post");
            }
        }
    }
}
