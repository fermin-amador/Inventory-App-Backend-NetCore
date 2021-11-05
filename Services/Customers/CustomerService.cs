using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _db;
        public CustomerService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        

        public ServiceResponse<Customer> CreateCustomer(Customer customer)
        {
            try
            {
                _db.Customers.Add(customer);

              

                _db.SaveChanges();

                return new ServiceResponse<Customer>
                {
                    Data = customer,
                    Time = DateTime.UtcNow,
                    Message = "Saved new Customer",
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Customer>
                {
                    Data = customer,
                    Time = DateTime.UtcNow,
                    Message = e.Message,
                    IsSuccess = false
                };

            }
           
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllProducts()
        {
            return _db.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _db.Customers.Find(id);
        }

        public Customer GetCustomerbyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
