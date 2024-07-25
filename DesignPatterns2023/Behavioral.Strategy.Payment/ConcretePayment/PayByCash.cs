﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.Payment
{
    public class PayByCash : IPayments
    {
        public void PayType(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
}