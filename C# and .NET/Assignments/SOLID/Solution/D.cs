using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    public interface ICustomerDataProcessor
    {
        public CustomerEntity GetCustomer(int id);
        public CustomerEntity AddCustomer(CustomerEntity customer);
        public CustomerEntity UpdateCustomer(CustomerEntity customer);
    }
    public class CustomerEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
    // Business Layer
    public class CustomerBusiness
    {
        private readonly ICustomerDataProcessor customerDataProcessor;
        public CustomerBusiness(ICustomerDataProcessor customerDataProcessor)
        {
            this.customerDataProcessor = customerDataProcessor;
        }
        public CustomerEntity CreateCustomer(CustomerEntity customer)
        {
            return customerDataProcessor.AddCustomer(customer);
        }
        public CustomerEntity GetCustomer(int id)
        {
            return customerDataProcessor.GetCustomer(id);
        }
    }

    // Database Layer
    public class CustomerDataProcessor : ICustomerDataProcessor
    {
        public CustomerEntity GetCustomer(int id) { return new CustomerEntity(); }
        public CustomerEntity AddCustomer(CustomerEntity customer) { return new CustomerEntity(); }
        public CustomerEntity UpdateCustomer(CustomerEntity customer) { return new CustomerEntity(); }
    }
}
