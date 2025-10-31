﻿using Microsoft.AspNetCore.Mvc;
using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;


        public OrderController(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;

        }


        public IActionResult Index()
        {
            var orders = _ordersRepository.GetAll();

            return View(orders);
        }


        public IActionResult Detail(Guid orderId)
        {
            var order = _ordersRepository.TryGetById(orderId);

            return View(order);
        }


        [HttpPost]
        public IActionResult UpdateStatus(Guid orderId, OrderStatus status)
        {
            _ordersRepository.UpdateStatus(orderId, status);

            return RedirectToAction(nameof(Index));
        }
    }
}
