using Behavioral.Strategy.SortingAlgo.StrategySort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.SortingAlgo.ContextSort
{
    public class ContextSorting<T>
    {
        private IStrategySort<T>? _strategy;
        //default constructure
        public ContextSorting()
        {
            this._strategy = null;
        }
        public ContextSorting(IStrategySort<T> strategy)
        {
            this._strategy = strategy;
        }

        //The context allows switch sorting algorithm at runtime
        public void SwitchSortingAlgorithm(T strategy)
        {
            this._strategy = (IStrategySort<T>?)strategy;
        }

        //Operate sorting. taking a list of string, call the PerformSoring() method. and return the result to the client.
        public List<string> SortObject(T data)
        {
           
            var result = this._strategy.PerformSorting(data);
            string resultStr = string.Empty;
            if (result != null) 
            { 

                foreach (var element in result as List<string>)
                {
                    resultStr += element + ",";
                }
           
            }
            return resultStr.Split(',').ToList(); // convert string to list
        }
    }
}
