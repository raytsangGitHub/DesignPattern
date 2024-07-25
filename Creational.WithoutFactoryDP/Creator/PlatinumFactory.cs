using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.WithoutFactoryDP.Creator
{
    public class PlatinumFactory : RefactorCreditCardFactoryMethod
    {
        public override ICreditCard GetCreditCardMethod()
        {
            return new Platinum();
        }
    }
}
