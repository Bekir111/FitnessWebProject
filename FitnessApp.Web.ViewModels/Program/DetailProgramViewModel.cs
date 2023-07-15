
namespace FitnessApp.Web.ViewModels.Program
{
    using FitnessApp.Web.ViewModels.Reviews;
    public class DetailProgramViewModel
    {
        public DetailProgramViewModel()
        {
            this.Reviews = new HashSet<ProgramReviewInDetailViewModel>();
        }
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string PictureUrl { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public double AverageRating { get; set; }

        public ICollection<ProgramReviewInDetailViewModel> Reviews { get; set; } = null!;


    }
}
