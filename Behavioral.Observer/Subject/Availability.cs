

namespace Behavioral.Observer
{
    public class Availability : IAvailability
    {
        INotification _notification;
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductAvailability { get; set; }

        public Availability(string productName, int productPrice, string productAvailability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductAvailability = productAvailability;
        }
        public string getAvailability()
        {
            return  ProductAvailability;
        }

        public void setAvailability(string availability)
        {
            ProductAvailability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            _notification.NotifyObservers();
        }
    }
}