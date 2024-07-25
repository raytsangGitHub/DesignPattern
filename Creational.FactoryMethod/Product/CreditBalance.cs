using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Product
{ 
    /// <summary>
    /// prove of extendibility
    /// </summary>
    public class CreditBalance : IExtendCreditCard
    {
        public int GetCreditBalance()
        {
            return 2222;
        }
    }
}
