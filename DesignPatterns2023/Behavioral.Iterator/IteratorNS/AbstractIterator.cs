using Behavioral.Iterator.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Behavioral.Iterator.IteratorNS
{
    public interface AbstractIterator
    {
        bool IsCompleted { get; }
        public Employee First();
        public Employee Next();

    }
}
