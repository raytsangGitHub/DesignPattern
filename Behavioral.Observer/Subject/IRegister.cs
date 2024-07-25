using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public interface IRegister
    {
        public void RegisterObserver(IObserver observer);
        public void AddObservers(IObserver observer);
        public void RemoveObserver(IObserver observer);
    }
}
