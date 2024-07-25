using Structural.Decorator.RefactoringGuru.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator.RefactoringGuru.Decorators
{
    public abstract class Decorator1 : Component
    {
        protected Component _component; //composition. To the componment interface

        //ctor. 
        public Decorator1(Component component)
        {
            this._component = component;
        }
         //set either the default and decorator component 
        //public void SetComponent(Component component)
        //{
        //    this._component = component;  //this method is not necessary, the constructor will set the component.
        //}

        // The Decorator delegates all work to the wrapped component.
        public override string Operation()
        {
            if (_component != null) { 
            return _component.Operation();  //return the operation to client
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
