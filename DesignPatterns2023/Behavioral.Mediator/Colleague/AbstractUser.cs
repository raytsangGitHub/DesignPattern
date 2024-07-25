using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal abstract class AbstractUser
    {
        // an abstract class reference to the mediator interface
        // Or its composed of mediator
        protected IFacebookGroupMediator mediator;
        protected string name;
        public AbstractUser(IFacebookGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
