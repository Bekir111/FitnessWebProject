
namespace FitnessApp.Web.Infrastructure.Extensions
{
    using System.Security.Claims;
    public static class ClaimsExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
