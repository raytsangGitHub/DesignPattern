using Creational.FactoryMethod.Notification.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Notification.Creator
{
    public abstract class NotifierFactory
    {
        public abstract INotifier CreateNotifier();
    }
}
