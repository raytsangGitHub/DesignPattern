using Structural.Proxy.RefactoringGuru.RealServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy.RefactoringGuru
{
    public class Client
    {
        public void ClientCode(IService service)
        {
            service.Request();
        }
    }
}
