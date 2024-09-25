﻿using Wipro_APIAndViewInSameProject.Models;

namespace Wipro_APIAndViewInSameProject.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer SearchCustomer(int id);
        int UpdateCustomer(Customer customer);
        int CreateCustomer(Customer customer);
        int DeleteCustomer(Customer customer);
    }
}
