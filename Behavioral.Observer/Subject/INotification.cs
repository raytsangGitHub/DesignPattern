using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public interface INotification
    {
        void NotifyObservers(Availability availability);
    }
}
