using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_Database_Approach.Models;
using Wipro_Database_Approach.Repository;

namespace Wipro_Database_Approach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }
        [HttpPost("CreateProduct")]
        public ActionResult CreateProduct(Product product)
        {
            return Ok(productRepository.CreateProduct(product));
        }
        [HttpGet("ShowProduct")]
        public ActionResult ShowAllProduct(Product product)
        {
            return Ok(productRepository.GetAllProducts());
        }
        [HttpGet("ShowProductById")]
        public ActionResult SearchProduct(Product product)
        {
            return Ok(productRepository.UpdateProduct(product));
        }

        [HttpDelete("DeleteProduct")]
        public ActionResult DeleteProduct(int productId)
        {
            return Ok(productRepository.DeleteProduct(productId));
        }
    }
}
