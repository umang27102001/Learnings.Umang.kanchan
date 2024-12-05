using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Question
{
    /* QUESTION
     * How are we breaking the ISP here ?
     * Try to fix by identifying behavior/methods which are not needed to be clubbed in a single contract.
     * Answer: We have clubbed the methods related to orders and customers in one single interface which violates the Interface segregation principle
     * the solution to this problem is shown in ISol.cs file
     */

    public interface CustomerInterface
    {
        public CustomerEntityI GetCustomer();
        public CustomerEntityI AddCustomer();
        public CustomerEntityI UpdateCustomerName();
        public OrderEntityI GetOrder();
        public OrderEntityI AddOrder();
        public OrderEntityI UpdateOrder();
    }

    public class CustomerEntityI
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class OrderEntityI
    {
        public int OrderNumber { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryName { get; set; }
    }

}
