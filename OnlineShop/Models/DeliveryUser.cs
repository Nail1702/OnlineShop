﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class DeliveryUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateOnly Date { get; set; }
        public string? Comment { get; set; }
    }
}
