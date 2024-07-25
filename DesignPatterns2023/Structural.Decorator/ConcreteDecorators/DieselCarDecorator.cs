using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
 
        public class DieselCarDecorator : CarDecorator
        {
            public DieselCarDecorator(ICar car) : base(car)  //injection
            {
            }
            //Overriding the ManufactureCar method to add Engine
            public override ICar ManufactureCar()
            {
                //First Call the Concrete Components ManufactureCar Method
                car.ManufactureCar();
                //Then Add the Engine
                AddEngine(car);
                return car;
            }
            public void AddEngine(ICar car)
            {
                if (car is BMWCar BMWCar)
                {
                    BMWCar.Engine = "Diesel Engine";
                    //The Console.WriteLine is uses the override ToString() method BMWCar class.
                    Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
                }
            }
        }
    
}
