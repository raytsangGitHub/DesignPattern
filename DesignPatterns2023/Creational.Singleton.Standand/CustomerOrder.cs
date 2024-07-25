using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Standand
{
    internal class CustomerOrder
    {
        private readonly SingletonLogger _singletonLogger;
        public CustomerOrder()
        {
            _singletonLogger = SingletonLogger.Instance;

        }

        public void PlaceOrder(int orderNumber)
        {
            _singletonLogger.LogInfo($"Order {orderNumber} is processed succefully");
        }
    }
}
