using Behavioral.Iterator.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Iterator.IteratorNS
{
    //ConcreteIterator ~ Iterator in the example
    internal class ConcreteIterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;

        public ConcreteIterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }

        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
        // Gets first item
        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
    }
}
