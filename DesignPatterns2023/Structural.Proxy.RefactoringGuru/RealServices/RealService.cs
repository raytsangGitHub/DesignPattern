using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy.RefactoringGuru.RealServices
{
    public class RealService : IService
    {
        public void Request()
        {
            Console.WriteLine("RealSubject : Handling Request.");
        }
    }
}
