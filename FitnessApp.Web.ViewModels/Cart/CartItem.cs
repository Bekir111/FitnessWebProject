namespace FitnessApp.Data.Models
{
    public class CartItem
    {
        public string ProductId { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total { get { return Quantity * Price; } }

        public string PictureUrl { get; set; } = null!;


    }
}
