namespace FitnessApp.Web.ViewModels.Product
{
    public class ProductAllViewModel
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string PictureUrl { get; set; } = null!;

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
