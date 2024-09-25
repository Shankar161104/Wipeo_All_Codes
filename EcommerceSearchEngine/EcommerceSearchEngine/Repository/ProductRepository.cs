using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceSearchEngine.Data;
using EcommerceSearchEngine.Models;

namespace EcommerceSearchEngine.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> SearchProductsAsync(SearchViewModel model)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(model.SearchTerm))
            {
                query = query.Where(p => p.ProductName.Contains(model.SearchTerm) ||
                                         p.Description.Contains(model.SearchTerm) ||
                                         p.Category.Contains(model.SearchTerm));
            }

            if (!string.IsNullOrEmpty(model.Category))
            {
                query = query.Where(p => p.Category == model.Category);
            }

            if (model.PriceMin.HasValue)
            {
                query = query.Where(p => p.Price >= model.PriceMin.Value);
            }

            if (model.PriceMax.HasValue)
            {
                query = query.Where(p => p.Price <= model.PriceMax.Value);
            }

            if (!string.IsNullOrEmpty(model.Brand))
            {
                query = query.Where(p => p.Brand == model.Brand);
            }

            if (model.RatingMin.HasValue)
            {
                query = query.Where(p => p.Rating >= model.RatingMin.Value);
            }

            if (model.InStock.HasValue)
            {
                query = query.Where(p => p.StockQuantity > 0);
            }

            switch (model.SortBy)
            {
                case "price_asc":
                    query = query.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    query = query.OrderByDescending(p => p.Price);
                    break;
                case "rating_desc":
                    query = query.OrderByDescending(p => p.Rating);
                    break;
                case "new_arrivals":
                    query = query.OrderByDescending(p => p.ProductID);
                    break;
                default:
                    query = query.OrderBy(p => p.ProductName);
                    break;
            }

            var products = await query.Skip((model.Page - 1) * model.PageSize)
                                      .Take(model.PageSize)
                                      .ToListAsync();

            return products.Select(p => new ProductDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Description = p.Description,
                Price = p.Price,
                Category = p.Category,
                Brand = p.Brand,
                Rating = p.Rating,
                ReviewsCount = p.ReviewsCount,
                StockQuantity = p.StockQuantity
            }).ToList();
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return new ProductDto
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category,
                Brand = product.Brand,
                Rating = product.Rating,
                ReviewsCount = product.ReviewsCount,
                StockQuantity = product.StockQuantity
            };
        }

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products.Select(p => new ProductDto
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Description = p.Description,
                Price = p.Price,
                Category = p.Category,
                Brand = p.Brand,
                Rating = p.Rating,
                ReviewsCount = p.ReviewsCount,
                StockQuantity = p.StockQuantity
            }).ToList();
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}