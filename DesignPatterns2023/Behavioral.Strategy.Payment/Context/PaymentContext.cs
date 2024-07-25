using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.Payment
{
    public class PaymentContext
    {
        private IPayments? PaymentStrategy;

        //method injection act as a switch for different strategy
        public void SetPaymentStrategy(IPayments strategy)
        {
            this.PaymentStrategy = strategy;
        }

        public void Pay(double amount)
        {
            PaymentStrategy.PayType(amount);
        }
    }
}
