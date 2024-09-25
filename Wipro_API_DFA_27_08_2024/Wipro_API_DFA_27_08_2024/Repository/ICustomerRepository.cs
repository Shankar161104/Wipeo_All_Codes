using Wipro_API_DFA_27_08_2024.Models;


namespace Wipro_API_DFA_27_08_2024.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer SearchCustomer(int CustomerID);
        Customer CreateCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(int Customerid);
    }
}
