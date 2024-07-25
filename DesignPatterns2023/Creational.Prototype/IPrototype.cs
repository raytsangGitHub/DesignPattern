using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
    internal interface IPrototype
    {
        public abstract object clone();
    }
}
