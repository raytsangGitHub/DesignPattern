using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge
{
    //This is an abstract class that contains members that define an abstract business object and its functionality.
    //It contains a reference to an object of type ILEDTV and delegates all of the real work to this object.
    //It can also act as the base class for other abstractions.
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;  //Bridge between abstract and the implementor.

        //public ILEDTV ILEDTV
        //{
        //    get => default;
        //    set
        //    {
        //    }
        //}

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
