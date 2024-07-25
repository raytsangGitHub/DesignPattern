using Structural.Decorator.RefactoringGuru.Components;
using Structural.Decorator.RefactoringGuru.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator.RefactoringGuru.ConcreteDecorators
{
    public class ConcreteDecoratorC : Decorator1
    {
        public ConcreteDecoratorC(Component component) : base(component)
        {

        }
        //multiple inheritance
        public override string Operation()
        {
            return $"ConcreteDecoratorC.{base.Operation()}";
        }

    }
}
