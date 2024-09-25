using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceSearchEngine.Models;

namespace EcommerceSearchEngine.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> SearchProductsAsync(SearchViewModel model);
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<List<ProductDto>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}