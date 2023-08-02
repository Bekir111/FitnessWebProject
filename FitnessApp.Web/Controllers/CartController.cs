
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Data.Models;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Cart;
    using FitnessApp.Services.Data.Interfaces;

    using static FitnessApp.Common.NotificationMessagesConstants;
    public class CartController : BaseController
    {
        private readonly IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            ICollection<CartItem> cart = HttpContext.Session.GetJson<ICollection<CartItem>>("Cart") ?? new HashSet<CartItem>();

            CartViewModel cartVM = new CartViewModel
            {
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Quantity * x.Price)
            };

            return View(cartVM);
        }

        public async Task<IActionResult> Add(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                return NotFound();
            }
            ICollection<CartItem> cart = HttpContext.Session.GetJson<ICollection<CartItem>>("Cart") ?? new HashSet<CartItem>();

            CartItem cartItem = cart.Where(c => c.ProductId.ToLower() == id.ToLower()).FirstOrDefault();

            try
            {
                if (cartItem == null)
                {
                    var item = await this.productService.FindProductById(id);
                    cart.Add(item);
                }
                else
                {
                    cartItem.Quantity += 1;
                }

                HttpContext.Session.SetJson("Cart", cart);
                TempData[SuccessMessage] = "You successfully added item to your cart!";
                return RedirectToAction("Index", "Cart");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
