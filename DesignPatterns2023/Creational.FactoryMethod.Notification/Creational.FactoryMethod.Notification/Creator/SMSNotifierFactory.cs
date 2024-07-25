using Creational.FactoryMethod.Notification.Product;

namespace Creational.FactoryMethod.Notification.Creator
{
    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
