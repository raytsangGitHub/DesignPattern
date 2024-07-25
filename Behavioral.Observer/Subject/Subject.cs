using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    //Use Solid Principle: an object only responsible for a single task. Here Availability, register and notify are all in one single class, whick violates the RSP.
    //
    public class Subject : Availability
    {
        
        public Subject(string productName, int productPrice, string productAvailability) : base(productName, productPrice, productAvailability)
        {
            
        }

        // 
  

        //protected List<IObserver> observers = new();
        //public string ProductName { get; set; }
        //public int ProductPrice { get; set; }
        //public string ProductAvailability { get; set; }
        //public Subject(string productName, int productPrice, string productAvailability)
        //{
        //    ProductName = productName;
        //    ProductPrice = productPrice;
        //    ProductAvailability = productAvailability;
        //}

        //public string getAvailability()
        //{
        //    return ProductAvailability;
        //}
        //public void setAvailability(string availability)
        //{
        //    this.ProductAvailability = availability;
        //    Console.WriteLine("Availability changed from Out of Stock to Available.");
        //    NotifyObservers();
        //}
        //public void RegisterObserver(IObserver observer)
        //{
        //    Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
        //    observers.Add(observer);
        //}
        //public void AddObservers(IObserver observer)
        //{
        //    observers.Add(observer);
        //}
        //public void RemoveObserver(IObserver observer)
        //{
        //    observers.Remove(observer);
        //}

    }
}
