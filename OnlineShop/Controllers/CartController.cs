using Microsoft.AspNetCore.Mvc;
using OnlineShop;
using OnlineShop.Repositories;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductsRepository _productsRepository;
        private readonly CartsRepository _cartsRepository;

        public CartController(ProductsRepository productsRepository, CartsRepository cartsRepository)
        {
            _productsRepository = productsRepository;
            _cartsRepository = cartsRepository;
        }

        public IActionResult Index()
        {
            var cart = _cartsRepository.TryGetByUserId(Constants.UserId);

            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = _productsRepository.TryGetById(productId);

            if (product != null)
            {
                _cartsRepository.Add(product, Constants.UserId);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
