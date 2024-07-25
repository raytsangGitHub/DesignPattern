using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.SortingAlgo.StrategySort
{

    public class SelectionSort<T> where T : IStrategySort<T>
    {
        /// <summary>
        /// Selection sort is a simple and efficient sorting algorithm that works by repeatedly selecting the smallest (or largest) element from the unsorted portion of the list, and moving it to the sorted portion of the list. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// 

        private readonly T _selection;
        public SelectionSort(T list)
        {
            this._selection = list;
        }

        public List<string> PerformSorting(List<string> data)
        {
            throw new NotImplementedException();
        }
    }
}
