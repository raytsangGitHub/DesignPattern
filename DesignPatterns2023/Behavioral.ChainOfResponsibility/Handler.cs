using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler rsHandler =null!;
        // abstract vs Interface, abstract class can have method with both bodyless and body with difinition. But interface can only have bodyless method.
        public void nextHandler(Handler rsHandler) 
        {
            this.rsHandler = rsHandler;
        }
        public abstract void dispatchRs(long requestedAmount);
    }
}
