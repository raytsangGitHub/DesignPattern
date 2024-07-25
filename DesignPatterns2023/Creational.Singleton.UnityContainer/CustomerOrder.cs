using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.UnityContainer
{
    internal class CustomerOrder
    {
        private readonly ISingletonLogger _singletonLogger;
        public CustomerOrder(ISingletonLogger singletonLogger)  //injection the singleton object
        {
            _singletonLogger = singletonLogger;

        }

        public void PlaceOrder(int orderNumber)
        {
            _singletonLogger.LogInfo($"Order {orderNumber} is processed succefully");
        }
    }
}
