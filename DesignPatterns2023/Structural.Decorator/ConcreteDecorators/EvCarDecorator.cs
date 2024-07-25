using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    public class EVCarDecorator : CarDecorator
    {

        public EVCarDecorator(ICar car) : base(car)
        {

        }

        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is BMWCar bMWCar)
            {
                bMWCar.Engine = "EV engine";
                Console.WriteLine("EVCarDecorator added EV Engine to the Car : " + car);
            }
        }
    }

     
}
