using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Repositories;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsRepository _productsRepository;

        public ProductController(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public IActionResult Index(int id)
        {
            var product = _productsRepository.TryGetById(id);

            return View(product);
        }
    }
}
