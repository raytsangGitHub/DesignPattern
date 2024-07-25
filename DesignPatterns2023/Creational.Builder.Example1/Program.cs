// See https://aka.ms/new-console-template for more information
//Reference: https://www.codeproject.com/Articles/470476/Understanding-and-Implementing-Builder-Pattern-in
//Definition: Separate the construction of a complex object from its representation so that the same construction process can create different representations.

//ConcreteBuilder: Concrete classes that will create the complex Product. this will keep track of what Product it has created i.e. assembled what parts and this will be used by the client to get the Product object.
//Builder: This is the interface for creating the actual products
//Director: It specify the parts needs to be put together to to create the actual concrete Product.
//Product: This is the object that will be created by assembling many parts.
// Lets create the Director first
using Creational.Builder.Example1;
// Client associated to the Director 
Manufacturer newManufacturer = new Manufacturer();
// Lets have the Builder class ready
IPhoneBuilder phoneBuilder = null;  //LSP

//object(instance level) dependency: create an android phone
phoneBuilder = new AndroidPhoneBuilder(); //create an Android instance.
//one-to-one (director to builder) association. aka Denpendency Injection, a constructor injection, aka  
newManufacturer.Construct(phoneBuilder);  
Console.WriteLine($"*** The new Phone built:\n\n{phoneBuilder.Phone.ToString()}");

// create a Windows Phone
phoneBuilder = new WindowsPhoneBuilder();
newManufacturer.Construct(phoneBuilder);
Console.WriteLine($"*** The new Phone built:\n\n{phoneBuilder.Phone.ToString()}");

//Test if the design follow the Solid principle:

//Lets add samsung by create a concret class SamsungPhoneBuilder.cs

//Is the design follow these principles?
//SRP: yes, each class responsible for only family related tasks - create phone
//OCP: yes, its open for extention by adding a samsungPhoneBuilder.cs to create a new phone w/o modify any other object
//LSP: yes, it uses interface for substitution like: IPhoneBuilder phoneBuilder = new WindowsPhoneBuilder();
//ISP: yes, all concrete class isn't forced to implement the unnecessary interface
//DIP: yes; high or low level module depends on abstraction. 
phoneBuilder = new SamsungPhoneBuilder();
newManufacturer.Construct(phoneBuilder);
Console.WriteLine($"*** The new Phone built:\n\n{phoneBuilder.Phone.ToString()}");

