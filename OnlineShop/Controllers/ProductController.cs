using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Repositories;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            var product = ProductsRepository.TryGetById(id);

            if (product == null)
            {
                return $"Товара с id = {id} не существует!";
            }
            return $"{product}{Environment.NewLine}{product?.Description}";
        }
    }
}
