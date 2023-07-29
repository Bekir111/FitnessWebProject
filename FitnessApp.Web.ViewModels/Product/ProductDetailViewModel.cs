using FitnessApp.Web.ViewModels.Reviews;

namespace FitnessApp.Web.ViewModels.Product
{
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel()
        {
            this.Reviews = new HashSet<ReviewInDetailViewModel>();
        }

        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

        public bool IsAvailable { get; set; }

        public string PictureUrl { get; set; } = null!;

        public ICollection<ReviewInDetailViewModel> Reviews { get; set; } = null!;

    }
}
