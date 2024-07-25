using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Strategy.RefactoringGuru.Strategy
{
    public class StrategyA : IStrategy
    {
        public List<string> DoAlgorithn(List<string> data)
        {
            List<string> list = data;
            list.Sort();
            return list;
        }
    }
}
