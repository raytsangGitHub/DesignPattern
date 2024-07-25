using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
   
        // The Base Decorator class is also inherited from the same interface as the other Concrete Components inherited. 
        // The primary responsibility of this Base Decorator class is to define the wrapping interface for all concrete decorators. 
        // The default implementation of the wrapping code includes a field for storing a wrapped component and
        // we need to initialize that field. Here, we are initializing that field using the class constructor
        //Inherited from the Base Component Interface
        public abstract class CarDecorator : ICar
        {
            //Wrapper uses coomposition that Creates a Field to store the Concrete Component
            protected ICar car;
            //Initializing the Field using Constructor
            public CarDecorator(ICar car) //Constructor Dependency injection
        {
                this.car = car;
            }
            //Providing Implementation for the Base Component Interface
            //Here, we are just calling the Concrete Component ManufactureCar method
            //We are making this Method Virtual to allow the Child Concrete Decorator class to override
            public virtual ICar ManufactureCar()
            {
                return car.ManufactureCar();
            }
        }
    
}
