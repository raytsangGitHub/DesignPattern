﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class ConcreteUser : AbstractUser
    {
        //using the parent class constructor 
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)  
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.name + ": Received Message:" + message);
        }
        public override void Send(string message)
        {
            Console.WriteLine(this.name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}
