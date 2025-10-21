using OnlineShop.Interfaces;
using OnlineShop.Models;

namespace OnlineShop.Repositories
{
    public class InMemoryOrdersRepository : IOrdersRepository
    {
        private readonly List<Order> _orders = [];

        public void Add(Order order)
        {
            order.CreationDateTime = DateTime.Now;
            order.DeliveryUser.Id = Guid.NewGuid();

            order.Id = Guid.NewGuid();

            _orders.Add(order);
        }
    }
}
