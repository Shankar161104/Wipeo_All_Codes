using Microsoft.AspNetCore.Razor.TagHelpers;
using Wipro_APIAndViewInSameProject.EntityFrameWork;
using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CustomerDbContext customerDbContext;

        public CustomerRepository(CustomerDbContext _customerDbContext)
        {
            customerDbContext = _customerDbContext;
        }

        public int CreateCustomer(Customer customer)
        {
            customerDbContext.Customers.Add(customer);
            return customerDbContext.SaveChanges();
        }

        public int DeleteCustomer(Customer customer)
        {
            if (customerDbContext==null)
            {
                throw new ArgumentException("Entity is missing");
            }
            customerDbContext.Customers.Remove(customer);
            return customerDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customerDbContext.Customers.ToList();
        }

        public Customer SearchCustomer(int id)
        {
            return customerDbContext.Customers.SingleOrDefault(t=>t.CustomerID==id);
        }

        public int UpdateCustomer(Customer customer)
        {
            if (customerDbContext == null)
            {
                throw new ArgumentException("Entity is missing");
            }
            customerDbContext.Customers.Update(customer);
            return customerDbContext.SaveChanges();
        }
    }
}
