﻿namespace OnlineShop.Models
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Cost { get; }
        public string? Description { get; }

        public Product(int id, string name, decimal cost, string? description)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id}{Environment.NewLine}{Name}{Environment.NewLine}{Cost:c}";
        }
    }
}