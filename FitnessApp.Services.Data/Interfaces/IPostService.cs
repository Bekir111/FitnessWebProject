
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Post;
    public interface IPostService
    {
        Task<ICollection<AllPostsViewModel>> GetAllPostsAsync();

        Task<DetailPostViewModel> GetPostForDetailAsync(int id);

        Task<PostFormModel> FindPostByIdForEditAndDelete(int id);

        Task<bool> IsPostExistbyId(int id);

        Task<bool> IsThisUserAuthorOfThePost(string userId, int postId);

        Task AddPost(PostFormModel model,string userId);

        Task EditExistingPost(PostFormModel model,int id);

        Task DeleteExistingPost(int id);
    }
}
