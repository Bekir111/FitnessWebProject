
namespace FitnessApp.Services.Data.Interfaces
{
    using FitnessApp.Web.ViewModels.Post;
    public interface IPostService
    {
        Task<ICollection<AllPostsViewModel>> GetAllPostsAsync();

        Task<DetailPostViewModel> GetPostForDetailAsync(int id);

        Task<bool> IsPostExistbyId(int id); 
    }
}
