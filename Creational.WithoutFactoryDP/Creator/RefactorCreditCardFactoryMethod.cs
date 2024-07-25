using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.WithoutFactoryDP.Creator
{
    //fixing the OCP violation with a factory method
    // 1. Create some creator classes in the creator folder
    // 2. Make a abstract creator 
    public abstract class RefactorCreditCardFactoryMethod
    {
        public abstract ICreditCard GetCreditCardMethod();
    }
}
