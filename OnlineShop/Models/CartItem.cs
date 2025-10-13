﻿namespace OnlineShop.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }

        public decimal? Cost => Product?.Cost * Quantity;
    }
}
