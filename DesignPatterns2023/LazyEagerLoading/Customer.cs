using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyEagerLoading
{
    public class Customer
    {
        private Lazy<List<Order>> _Orders;
        public string CustomerName { get; set; }
        public List<Order> Orders 
        { 
            get
            { 
              return _Orders.Value;  //the value is the property of Lazy object.
            }
        }

        public Customer()
        {
            //The customer and order data will load soon as this object instantiate.
            CustomerName = "Joe";
            //remove this to perform and do it in the constructor for Lazy loading
            // _orders = LoadOrders();  //Composition: The composed object

            //for Lazy<>
            _Orders = new Lazy<List<Order>>(() => LoadOrders());
        }
      

        private List<Order> LoadOrders()
        {

            List<Order> _temp = new List<Order>()
            {
                new Order { OrderNumber = "ord1001" },
                new Order { OrderNumber = "ord1002" }
            };

            //*** These is wrong way of adding object to the List<>, it result to all element int the list same value. 
            //Order o = new();
            //o.OrderNumber = "ord1001";
            //_temp.Add(o); // something wrong with the adding the o
            //o.OrderNumber = "ord1002";
            //_temp.Add(o);


            return _temp;
        }
    }
}
