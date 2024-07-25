using Creational.FactoryMethod.Notification.Product;

namespace Creational.FactoryMethod.Notification.Creator
{
    public class PushNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();
        }
    }
}
