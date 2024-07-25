using Structural.Proxy.RefactoringGuru.RealServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy.RefactoringGuru.Proxies
{
    public class Proxy1 : IService
    {
        private RealService _realServices;
        public Proxy1(RealService realService)
        {
            this._realServices = realService;
        }
        public void Request()
        {
            if (this.CheckAccess())
                this.LogAccess();
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
