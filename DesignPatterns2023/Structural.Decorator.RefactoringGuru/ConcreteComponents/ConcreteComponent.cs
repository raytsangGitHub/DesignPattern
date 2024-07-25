using Structural.Decorator.RefactoringGuru.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator.RefactoringGuru.ConcreteComponents
{
    
    public class ConcreteComponent : Component
    {
        // Concrete Components provide default implementations of the operations.
        // There might be several variations of these classes, ex. function uses method overloading. 
        public override string Operation()
        {
            return "ConcreteComponent";
        }

        //these are the variations, not using in this app, just for demo
        public void Operation(int test)
        {

        }
        public void Operation(string opt) { }

        public override string WriteOperation()
        {
            return "Overrided WriteOperation";
        }
    }
}
