using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Services.Customers
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerbyId(int id);
        ServiceResponse<Customer> CreateCustomer(Customer Customer);
       


    }
}
