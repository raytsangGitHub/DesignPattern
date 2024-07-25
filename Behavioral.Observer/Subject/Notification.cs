using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public class Notification : INotification 
    {
        Register _register = new();
        public void NotifyObservers(Availability availability)
        {
            Console.WriteLine("Product Name :"
                            + availability.ProductName + ", product Price : "
                            + availability.ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();
            foreach (IObserver observer in _register.observers)
            {
                observer.update(availability.ProductAvailability);
            }
        }
    }
}
