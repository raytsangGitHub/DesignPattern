using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.SubSystems
{
    public class Shipping : IShipping
    {
        public void ShippingStatus()
        {
            Console.WriteLine("Product is shipped.");
        }
    }
}
