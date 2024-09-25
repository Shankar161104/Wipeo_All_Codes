using Wipro_API_CodeFirstApproach.Entity_Framework;
using Wipro_API_CodeFirstApproach.Model;

namespace Wipro_API_CodeFirstApproach.Repository
{
    public class CustomerService:ICustomerService
    {
        public readonly ApplicationDbContext applicationDbContext;

        public CustomerService(ApplicationDbContext _applicationDbContext)

        {

            applicationDbContext = _applicationDbContext;

        }

        public Customer CreateCustomer(Customer customer)

        {

            var result = applicationDbContext.Customers.Add(customer);

            applicationDbContext.SaveChanges();

            return result.Entity;

        }

        public bool DeleteCustomer(int customerId)

        {

            var filteredData = applicationDbContext.Customers.

                         Where(x => x.CustomerId == customerId).FirstOrDefault();

            var result = applicationDbContext.Customers.Remove(filteredData);

            applicationDbContext.SaveChanges();

            return result != null ? true : false;

        }

        public IEnumerable<Customer> GetCustomer()

        {

            return applicationDbContext.Customers.ToList();

        }

        public Customer SearchCustomer(int Custid)

        {

            return applicationDbContext.Customers.SingleOrDefault(t => t.CustomerId == Custid);

        }

        public Customer UpdateCustomer(Customer customer)

        {

            if (customer == null)

            {

                throw new ArgumentNullException("Entity Missing");

            }

            var result = applicationDbContext.Update(customer);

            applicationDbContext.SaveChanges();

            return result.Entity;

        }

        
    }
}
