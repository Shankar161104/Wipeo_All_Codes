namespace EcommerceSearchEngine.Models
{
    public class ProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public double Rating { get; set; }
        public int ReviewsCount { get; set; }
        public int StockQuantity { get; set; }
    }
}