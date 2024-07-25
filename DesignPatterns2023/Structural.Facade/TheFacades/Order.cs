using Structural.Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.TheFacades
{

    /// <summary>
    /// Problem statement: imagine an existing libray/framework that have alot of functionalities, but an application only requires specific features to do its work. Solution is to create a facade to expose only those features to the client.
    /// Purpose: provide a unified interface to the subsystem.
    /// When to apply facade:
    /// 1. We want to provide a simple interface to a complex subsystem. 
    /// 2. There are many dependencies between clients and the implementation classes.
    /// </summary>
    public class Order : IOrder
    {
        // The simple interface to a complex subsystem.
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            //using LSP and the facade is decoupled with the subsystem,
            // but violated OCP, Because client is coupled with the facade class. added an IOrder interface
            // In the case of extend the facade, what will happen?  Create interfaces/abstract classes
            IProduct product = new Product();
            product.GetProductDetails();
            IPayment payment = new Payment();
            payment.MakePayment();
            IInvoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");

           


        }

    }

    //lets extend the facade by adding shipping object
    // What are the ways:  
    // using inheritanc
    public class ExtendOrder : IOrder
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Shipping Started");
            IShipping shipping = new Shipping();
            shipping.ShippingStatus();
        }
    }

    // using decorator by adding functionality to the existing facade
}
