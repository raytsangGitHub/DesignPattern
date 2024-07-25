using Creational.AbstractFactory.ProductsAndConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }
}
