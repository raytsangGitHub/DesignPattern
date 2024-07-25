using Creational.AbstractFactory.AbstractFactory;
using Creational.AbstractFactory.ProductsAndConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory
{
    internal class SeaAnimalFactory : AnimalFactoryBase
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null!;
        }

        public override AnimalFactoryBase MakeFactory()
        {
            throw new NotImplementedException();
        }
    }
}
