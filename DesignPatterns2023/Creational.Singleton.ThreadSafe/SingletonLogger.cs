using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.ThreadSafe.Lock
{
    //keys to remember:
    //1. Singleton should be sealed. prevent from inheritance
    //2. the constructor should be private and accepts no parameter
    //3. It should provide a lock to prevent simultious multi thread access
    //4. All fields should by private static and the lock should be readonly
    //5. Singleton can be implemented in a public 5a) property or 5b) public method.
    public sealed class SingletonLogger  //1. Sealed class
    {
        private static SingletonLogger? _instance;  //2. privat static field to hold the instance
        // use thread locking
        private static readonly object _Lock = new();  //create the lock object, this can be any resouces(data structure or device) that you want to lock
        private SingletonLogger()  //3. private, paramentless, single constructor
        {
            Console.WriteLine("Logger constructor executed");
        }

        //5a. implement singleton in property
        public static SingletonLogger Instance
        {
            get
            {
                if (_instance == null)  //in multi thread, there will be many instance accessing this object.  that's why we need to create a lock.
                    {
                    //the fix for multi-thread problem.
                    //locking is to prevent simultinious access.
                    //it is to make the other threads to waite until the first thread is done.
                    //The lock statement is used to lock a resource while others in use.
                    lock (_Lock)  
                        {
                        //  return  _instance == null ? _instance = new SingletonLogger() : _instance;

                        //return new SingletonLogger() ?? _instance; //null-coalescing operator 

                        if (_instance == null)
                        {
                            _instance = new SingletonLogger();  //creates the singleton instance
                        }

                    }
                }
             return _instance;
            }

        }
        // 5b)implement singleto in a method public method.
        public static SingletonLogger Instance_method()
        {
            if (_instance == null)
            {
                lock (_Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonLogger();
                    }
                }
            }
            return _instance;
        }
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
