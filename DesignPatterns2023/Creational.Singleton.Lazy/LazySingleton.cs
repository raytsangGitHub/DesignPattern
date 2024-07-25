using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Lazy
{
    public sealed class LazySingleton
    {
        public string? Value {  get; set; }

        private static readonly Lazy<LazySingleton> _lazy = new Lazy<LazySingleton>(() => new LazySingleton());
        private LazySingleton()  //make the ctor private
        {
            
        }
       

        public static LazySingleton GetInstance(string value)
        {
            var instance = _lazy.Value;
            instance.Value=value; //assign value to instance property
            return instance;
        }

        // Public property to access the singleton instance
        public static LazySingleton Instance
        {
            get
            {
                // The Value property calls the factory method if it hasn't been called before
                return _lazy.Value;
            }
        }
    }
}
