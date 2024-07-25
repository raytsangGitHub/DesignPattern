using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.SortingAlgo.StrategySort
{

    public interface IStrategySort<T>
    {
        T PerformSorting(T data);
    }
}
