using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.RefactoringGuru.Strategy
{
    public class StrategyB : IStrategy
    {
        public List<string> DoAlgorithn(List<string> data)
        {
            List<string> list = data;
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
