using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Example1
{

    //The director class defines the order in which to execute the building steps, while the builder provides the implementation for those steps.

    public class Manufacturer
    {
        //The construct method is associated to the builder object, a 1-to-1 assoication)
        public void Construct(IPhoneBuilder phoneBuilder)  
        {
            phoneBuilder.BuildStylus();
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            
        }
    }
}
