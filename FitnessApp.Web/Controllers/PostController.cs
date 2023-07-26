
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    using FitnessApp.Web.Infrastructure.Extensions;

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
        public async Task<IActionResult> Detail(int id,string information)
        {
            bool postExist = await this.postService.IsPostExistbyId(id);
            if (!postExist)
            {
                return NotFound();
            }

            var model = await this.postService.GetPostForDetailAsync(id);

            if (model.GetUrlInfo() != information)
            {
                return NotFound();
            }

            try
            {
                var viewwModel = await this.postService.GetPostForDetailAsync(id);

                return View(viewwModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
