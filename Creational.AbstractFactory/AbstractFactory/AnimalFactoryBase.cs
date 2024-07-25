using Creational.AbstractFactory.ProductsAndConcreteProducts;
using Creational.AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creational.AbstractFactory.ConcreteFactory;
using System.Runtime.CompilerServices;

namespace Creational.AbstractFactory.AbstractFactory
{
    //an interface/abstract class for creating families of related dependent objects without specifying their concrete classes.
    public abstract class AnimalFactoryBase
    {
        public abstract IAnimal GetAnimal(string AnimalType);
        public static AnimalFactoryBase CreateAnimalFactory(string FactoryType)
        {
            //this violates the OCP. will implement smiliar to the factory method with DSP or DI
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }

        //new implementation - follow OCP 
        public abstract AnimalFactoryBase MakeFactory() ;
        public  AnimalFactoryBase CreateAnimalFactoryWithFactoryMethod() 
        { 
            return this.MakeFactory();
        }
    }
}
