using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility.one
{
    
    public interface IChain
    {
        public abstract void setNext(IChain nextInChain);
        public abstract void process(Number request);
    }
}
