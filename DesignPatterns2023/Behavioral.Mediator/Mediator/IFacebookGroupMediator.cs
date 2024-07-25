using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    /// <summary>
    ///An interface and it defines all possible interactions between colleagues.
    /// </summary>
    internal interface IFacebookGroupMediator
    {
        void SendMessage(string msg, AbstractUser user);
        void RegisterUser(AbstractUser user);
    }
}
