using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.Payment
{
    public interface IPayments
    {
        void PayType(double amount);
    }
}
