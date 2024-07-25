using Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    internal class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        //this class is composed AbstractUsers. see diagram in note
        private readonly List<AbstractUser> _usersList = new();

        public void RegisterUser(AbstractUser user)
        {
            _usersList.Add(user);
        }
        public void SendMessage(string message, AbstractUser user)
        {
            foreach (var u in _usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
