
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Post;

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

        [HttpGet]
        public IActionResult Add()
        {
            return View(new PostFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.postService.AddPost(model, this.User.GetId());
                TempData[SuccessMessage] = "You added a post successfully!";
                return RedirectToAction("All", "Post");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
