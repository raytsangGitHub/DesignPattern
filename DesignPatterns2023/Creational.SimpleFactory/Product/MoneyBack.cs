﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.SimpleFactory
{
    internal class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "MoneyBack"; 
        }

        public int GetCreditLimit()
        {
            return 500;
        }
    }
}
