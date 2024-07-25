using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Standand
{
    //the basic way to implement singleton. but its not thread safe.
    internal sealed class SingletonLogger
    {
        private static SingletonLogger? _instance; //make the instance to private static
        //The constructor should be private and not accept any parameter value to make it a singleton
        private SingletonLogger()
        {
            Console.WriteLine("The constructor should be private and not accept any parameter value to make it a singleton. ");
        }
        //create the single instance
        public static SingletonLogger Instance 
        { 
            get
            {
                return _instance == null ? _instance = new SingletonLogger() : _instance;


                //if (_instance == null)  //enforce the singleton here.
                //{
                //    _instance = new SingletonLogger();  
                //}
                // return _instance;
            }
          
        }
            
        public void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}
