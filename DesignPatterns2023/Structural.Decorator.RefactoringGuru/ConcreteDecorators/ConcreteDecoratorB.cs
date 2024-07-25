using Structural.Decorator.RefactoringGuru.Components;
using Structural.Decorator.RefactoringGuru.Decorators; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator.RefactoringGuru.ConcreteDecorators
{
    public class ConcreteDecoratorB : Decorator1
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
