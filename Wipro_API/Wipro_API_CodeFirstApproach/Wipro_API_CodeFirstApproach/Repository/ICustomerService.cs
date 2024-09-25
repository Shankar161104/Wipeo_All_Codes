using Wipro_API_CodeFirstApproach.Model;

namespace Wipro_API_CodeFirstApproach.Repository
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomer();
        Customer SearchCustomer(int id);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}
