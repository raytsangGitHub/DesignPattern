using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer;

public class Observer : IObserver
{
    public string UserName { get; set; }

    //the ctor
    public Observer(string userName, IRegister register)
    {
        UserName = userName;
        register.RegisterObserver(this);
    }
    
    public void update(string availabiliy)
    {
        Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
    }
}
