using Behavioral.Strategy.RefactoringGuru.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.RefactoringGuru.Context
{
    public class Context
    {
        //context maintains a reference to one of the strategy objects.
        private IStrategy? _strategy;
        public Context()
        {
            this._strategy = null; 
        }
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        //The context allows replacement of strategy object at runtime
        public void SetStrategy(IStrategy strategy) 
        { 
            this._strategy = strategy; 
        }

        public void DoSomeBusinessLogic()
        {
           
            Console.WriteLine($"Context: Sorting: a, c, b, d, e");
            
            List<string> result = this._strategy.DoAlgorithn(new List<string>() { "a", "c", "b", "d", "e" });
            string resultStr = string.Empty;

            foreach (var element in result)
            {
                resultStr += element + ",";
            }
            Console.WriteLine(resultStr);
        }
    }
}
