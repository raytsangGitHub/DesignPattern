using Creational.FactoryMethod.Notification.Product;

namespace Creational.FactoryMethod.Notification.Creator
{
    //Concrete Creators
    public class EmailNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new EmailNotifier();
        }
    }
}
