using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.UnityContainer
{
    internal class SingletonLogger :ISingletonLogger
    {
        public SingletonLogger()  //Fix: make this public to use the unity container.
        {
            Console.WriteLine("Logger constructor executed\n");
        }
                
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
