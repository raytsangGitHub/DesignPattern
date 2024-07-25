using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge.Abstraction
{
    // This is going to be a concrete class which inherits from the Abstraction class - AbstractRemoteControl. 
    // This Redefined/extended the Abstraction Class- AbstractRemoteControl class.
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILEDTV ledTv)  //constructor injection
        {
            this.ledTv = ledTv;  
        }
        //calling the implementations.
        public override void SwitchOn()
        {
            ledTv.SwitchOn();  //calling the implementator
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }
}
