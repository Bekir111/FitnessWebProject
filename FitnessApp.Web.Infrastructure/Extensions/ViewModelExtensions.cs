using FitnessApp.Web.ViewModels.Post.Interfaces;

namespace FitnessApp.Web.Infrastructure.Extensions
{
    public static class ViewModelExtensions
    {
        public static string GetUrlInfo(this IPostDetailModel model)
        {
            return model.Title.Replace(" ", "-");
        }
    }
}
