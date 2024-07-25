// See https://aka.ms/new-console-template for more information

// To dynamically add new functionalities to an existing object without altering or modifying its structure. it acts like a wrapper to the existing class.

//Create an instance of Concrete Component
using Structural.Decorator;

ICar bmwCar1 = new BMWCar();  //LS principle
//Calling the ManufactureCar method will create the car without an engine
bmwCar1.ManufactureCar();
Console.WriteLine(bmwCar1 + "\n");
//Adding Diesel Engine to the bmwCar1
//Create an instance DieselCarDecorator class and bmwCar1 as a parameter to the Constructor
DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1); // Constructor Dependency injection 
//Calling the ManufactureCar method will add Diesel Engine to the bmwCar1 car
carWithDieselEngine.ManufactureCar();
Console.WriteLine();
ICar bmwCar2 = new BMWCar();
PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
carWithPetrolEngine.ManufactureCar();

Console.WriteLine();
Console.WriteLine("For EV");
ICar bmwCar3 = new BMWCar();
EVCarDecorator carWithEVEngine = new EVCarDecorator(bmwCar3);
carWithEVEngine.ManufactureCar();

Console.ReadKey();
