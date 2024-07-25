namespace Creational.FactoryMethod.Notification.Product
{
    public class PushNotifier : INotifier
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending Push Notification: {message}");
            // Actual push notification logic goes here...
        }
    }
}
