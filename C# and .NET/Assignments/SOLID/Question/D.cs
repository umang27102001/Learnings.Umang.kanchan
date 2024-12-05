using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Question
{
    public class CustomerEntityD
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    // Business Layer
    public class CustomerBusinessD
    {
        private readonly CustomerDataProcessor _customerDataProcessor;
        public CustomerBusinessD(CustomerDataProcessor customerDataProcessor)
        {
            this._customerDataProcessor = customerDataProcessor;
        }
        public CustomerEntityD CreateCustomer(CustomerEntityD customer)
        {
            return _customerDataProcessor.AddCustomer(customer);
        }
        public CustomerEntityD GetCustomer(int id)
        {
            return _customerDataProcessor.GetCustomer(id);
        }
    }

    // Database Layer
    public class CustomerDataProcessor
    {
        public CustomerEntityD GetCustomer(int id) { return new CustomerEntityD(); }
        public CustomerEntityD AddCustomer(CustomerEntityD customer) { return new CustomerEntityD(); }
        public CustomerEntityD UpdateCustomer(CustomerEntityD customer) { return new CustomerEntityD(); }
    }
}
