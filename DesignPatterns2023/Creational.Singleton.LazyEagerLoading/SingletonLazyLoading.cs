using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.LazyEagerLoading
{
    internal sealed class SingletonLazyLoading
    {
        private static int counter = 0;
        private SingletonLazyLoading()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static readonly Lazy<SingletonLazyLoading> instanceLocK = new Lazy<SingletonLazyLoading>(() => new());

        public static SingletonLazyLoading GetInstance { get { return instanceLocK.Value; } }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


    }
}
