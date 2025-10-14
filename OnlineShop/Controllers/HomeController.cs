using Microsoft.AspNetCore.Mvc;
using OnlineShop.Repositories;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsRepository _productsRepository;

        public HomeController(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public IActionResult Index()
        {
            var products = _productsRepository.GetAll();

            return View(products);
        }
    }
}
