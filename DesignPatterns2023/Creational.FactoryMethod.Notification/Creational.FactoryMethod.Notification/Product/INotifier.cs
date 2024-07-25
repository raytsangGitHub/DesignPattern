using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Notification.Product
{
    public interface INotifier
    {
        void SendNotification(string message);
    }
}
