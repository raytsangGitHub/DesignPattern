using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade.RefactoringGuru.TheSubSystems
{
    public class Subsystem1
    {
        public string operation1()
        {
            return "Subsystem1: ready? \n";
        }
        public string operationN()
        {
            return "Subsystem1: Go?\n";
        }
    }
}
