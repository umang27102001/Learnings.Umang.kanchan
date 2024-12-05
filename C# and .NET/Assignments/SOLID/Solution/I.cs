using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    /* Here we have segerated the Methods related to Order and Customer to implement Interface segregation */
    public interface OrderInterfaceI
    {
        public OrderEntityI GetOrder();
        public OrderEntityI AddOrder();
        public OrderEntityI UpdateOrder();
    }
    public interface CustomerInterfaceI
    {
        public CustomerEntityI GetCustomer();
        public CustomerEntityI AddCustomer();
        public CustomerEntityI UpdateCustomerName();
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
