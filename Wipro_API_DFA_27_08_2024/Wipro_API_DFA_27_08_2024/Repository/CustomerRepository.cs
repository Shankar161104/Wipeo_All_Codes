using Wipro_API_DFA_27_08_2024.Models;


namespace Wipro_API_DFA_27_08_2024.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly WiproDfa26082024Context wiproDfa26082024Context;
        public CustomerRepository(WiproDfa26082024Context _wiproDfa26082024Context)
        {
            wiproDfa26082024Context = _wiproDfa26082024Context;
        }

        public Customer CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            var result = wiproDfa26082024Context.Add(customer);
            wiproDfa26082024Context.SaveChanges();
            return result.Entity;

        }

        public bool DeleteCustomer(int Customerid)
        {
            var filteredData = wiproDfa26082024Context.Customers.Where(x=>x.CustomerId==Customerid).FirstOrDefault();
            wiproDfa26082024Context.Customers.Remove(filteredData);
            wiproDfa26082024Context.SaveChanges();
            return filteredData!=null?true:false;


        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return wiproDfa26082024Context.Customers.ToList();
        }

        public Customer SearchCustomer(int CustomerID)
        {
            return wiproDfa26082024Context.Customers.Where(x=>x.CustomerId==CustomerID).FirstOrDefault();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var result = wiproDfa26082024Context.Customers.Update(customer);
            wiproDfa26082024Context.SaveChanges();
            return result.Entity;
        }
    }
}
