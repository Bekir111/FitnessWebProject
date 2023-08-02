using FitnessApp.Data.Models;

namespace FitnessApp.Web.ViewModels.Cart
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            this.CartItems = new HashSet<CartItem>();
        }

        public ICollection<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
