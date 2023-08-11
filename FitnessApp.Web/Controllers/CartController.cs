
namespace FitnessApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using FitnessApp.Data.Models;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Web.ViewModels.Cart;
    using FitnessApp.Services.Data.Interfaces;

    using static FitnessApp.Common.NotificationMessagesConstants;
    using FitnessApp.Web.ViewModels;

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

            CartItem? cartItem = cart.Where(c => c.ProductId.ToLower() == id.ToLower()).FirstOrDefault();

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
                return GeneralError();
            }
        }

        public async Task<IActionResult> Decrease(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                return NotFound();
            }
            ICollection<CartItem> cart = HttpContext.Session.GetJson<ICollection<CartItem>>("Cart");

            CartItem? cartItem = cart.Where(c => c.ProductId.ToLower() == id.ToLower()).FirstOrDefault();

            try
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity--;
                }
                else
                {
                    cart.Remove(cartItem);
                }

                if (cart.Count == 0)
                {
                    HttpContext.Session.Remove("Cart");
                }
                else
                {
                    HttpContext.Session.SetJson("Cart", cart);
                }
                TempData[WarningMessage] = "You successfully removed item from your cart!";
                return RedirectToAction("Index", "Cart");

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Remove(string id)
        {
            bool isExist = await this.productService.IsProductExist(id);
            if (!isExist)
            {
                return NotFound();
            }
            ICollection<CartItem> cart = HttpContext.Session.GetJson<ICollection<CartItem>>("Cart");

            CartItem? cartItem = cart.Where(c => c.ProductId.ToLower() == id.ToLower()).FirstOrDefault();

            try
            { 
                cart.Remove(cartItem);

                if (cart.Count == 0)
                {
                    HttpContext.Session.Remove("Cart");
                }
                else
                {
                    HttpContext.Session.SetJson("Cart", cart);
                }
                TempData[WarningMessage] = "You successfully removed item from your cart!";
                return RedirectToAction("Index", "Cart");

            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("Cart");

            TempData[WarningMessage] = "You successfully cleared the items from your cart!";

            return RedirectToAction("Index", "Cart");

        }

        public IActionResult Checkout()
        {
            HttpContext.Session.Remove("Cart");

            TempData[SuccessMessage] = "You successfully ordered the products!";

            return RedirectToAction("Index", "Cart");

        }
    }
}
