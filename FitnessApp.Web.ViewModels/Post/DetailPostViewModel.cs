using FitnessApp.Web.ViewModels.Post.Interfaces;

namespace FitnessApp.Web.ViewModels.Post
{
    public class DetailPostViewModel : IPostDetailModel
    {
        public int Id { get; set; }

        public string Text { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public string Title { get; set; } = null!;
    }
}
