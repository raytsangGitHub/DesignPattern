using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Bridge.RefactoringGuru.Implementations
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return $"ConcreteImplementationA: The result in platform A. \n";
        }
    }


}
