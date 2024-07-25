using Creational.AbstractFactory.AbstractFactory;
using Creational.AbstractFactory.ProductsAndConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.ConcreteFactory
{
    public class LandAnimalFactory : AnimalFactoryBase
    {
        // this violates OCP, solution is to use factory method
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null!;
        }

        public override AnimalFactoryBase MakeFactory()
        {
            throw new NotImplementedException();
        }
    }
    //solution: is to use factory method
    public abstract class LandAnimalFactoryMethod : AnimalFactoryBase
    {
        public abstract IAnimal MakeAmial();
        public override IAnimal GetAnimal(string AnimalType)
        {
            return MakeAmial();
        }
    }
}
