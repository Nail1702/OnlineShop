namespace OnlineShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public List<CartItem>? Items { get; set; }
        public int Quantity => Items.Sum(item => item.Quantity);

        public decimal? TotalCost => Items?.Sum(item => item.Cost);
    }
}
