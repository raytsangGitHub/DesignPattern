using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behavioral.Iterator.IteratorNS;

namespace Behavioral.Iterator.Aggregate
{
    public interface AbstractCollection
    {
        AbstractIterator CreateIterator();
    }
}