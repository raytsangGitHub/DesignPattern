﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    public interface ATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
