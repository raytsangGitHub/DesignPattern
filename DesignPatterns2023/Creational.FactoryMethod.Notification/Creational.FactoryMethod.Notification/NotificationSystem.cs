using Creational.FactoryMethod.Notification.Creator;
using Creational.FactoryMethod.Notification.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Notification
{
    //this is the factory method
    public class NotificationSystem
    {
        public void NotifyUser(NotifierFactory factory, string message)
        {
            INotifier notifier = factory.CreateNotifier();
            notifier.SendNotification(message);
        }
    }
}
