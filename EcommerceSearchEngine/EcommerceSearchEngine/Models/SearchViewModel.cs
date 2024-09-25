using System.Collections.Generic;

namespace EcommerceSearchEngine.Models
{
    public class SearchViewModel
    {
        public string SearchTerm { get; set; }
        public string Category { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
        public string Brand { get; set; }
        public double? RatingMin { get; set; }
        public bool? InStock { get; set; }
        public string SortBy { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public List<Product> Products { get; set; }
    }
}