using FitnessApp.Web.ViewModels.Post.Interfaces;

namespace FitnessApp.Web.ViewModels.Post
{
    public class AllPostsViewModel : IPostDetailModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;
    }
}
