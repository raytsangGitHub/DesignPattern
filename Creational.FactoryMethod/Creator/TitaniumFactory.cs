using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactoryBase
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium(); //LSP 
            return product;
        }
    }
}
