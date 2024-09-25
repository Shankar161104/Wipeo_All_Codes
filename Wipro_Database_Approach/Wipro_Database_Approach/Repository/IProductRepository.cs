using Wipro_Database_Approach.Models;

namespace Wipro_Database_Approach.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product SearchProduct(int Productid);
        Product CreateProduct(Product product);
        Product UpdateProduct(Product product);
        bool DeleteProduct(int Productid);
    }
}
