using Wipro_Database_Approach.Models;

namespace Wipro_Database_Approach.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly WiproDfa26082024Context wiproDfa26082024Context;

        public ProductRepository(WiproDfa26082024Context _wiproDfa26082024Context)

        {


            wiproDfa26082024Context = _wiproDfa26082024Context;

        }

        public Product CreateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            var result = wiproDfa26082024Context.Add(product);
            wiproDfa26082024Context.SaveChanges();
            return result.Entity;
        }


        public bool DeleteProduct(int Productid)
        {
            var filteredData = wiproDfa26082024Context.Products.Where(x => x.Id == Productid).FirstOrDefault();

            wiproDfa26082024Context.Products.Remove(filteredData);

            wiproDfa26082024Context.SaveChanges();

            return filteredData != null ? true : false;

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return wiproDfa26082024Context.Products.ToList();
        }

        public Product SearchProduct(int Productid)
        {
            return wiproDfa26082024Context.Products.Where(t => t.Id == Productid).FirstOrDefault();
        }

        public Product UpdateProduct(Product product)
        {
            var result = wiproDfa26082024Context.Products.Update(product);

            wiproDfa26082024Context.SaveChanges();

            return result.Entity;

        }
    }


}

