
namespace FitnessApp.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;

    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.ViewModels.User;
    using static FitnessApp.Common.GeneralApplicationConstants;
    public class UserController : BaseAdminController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(IUserService userService, IMemoryCache memoryCache)
        {
            this.userService = userService;
            this.memoryCache = memoryCache;
        }

        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Client, NoStore = false)]
        public async Task<IActionResult> All()
        {
            var users = this.memoryCache.Get<ICollection<UserViewModel>>(UsersCacheKey);

            if (users == null)
            {
                users = await this.userService.GetUsers();

                MemoryCacheEntryOptions cacheOptions =
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(UsersCacheDurationMinutes));

                this.memoryCache.Set(UsersCacheKey, users, cacheOptions);
            }

            return View(users);
        }
    }
}
