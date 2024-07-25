// See https://aka.ms/new-console-template for more information

//Definition: “The Abstract Factory Design Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes“.
// It is a super factory that creates other factories. Also known as the Factory of Factories.
//Abstract Factory design pattern:
// provides an interface for creating families of related or dependent products, but leaves the actual object creation to the concrete factory classes.
using System.Data.Common;
using Creational.AbstractFactory.AbstractFactory;
using Creational.AbstractFactory.ProductsAndConcreteProducts;




IAnimal animal = null!;
AnimalFactoryBase animalFactory = null!;
string speakSound = null!;
// Create the Sea Factory object by passing the factory type as Sea
animalFactory = AnimalFactoryBase.CreateAnimalFactory("Sea");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();
// Get Octopus Animal object by passing the animal type as Octopus
animal = animalFactory.GetAnimal("Octopus");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();
Console.WriteLine("--------------------------");
// Create Land Factory object by passing the factory type as Land
animalFactory = AnimalFactoryBase.CreateAnimalFactory("Land");
Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
Console.WriteLine();
// Get Lion Animal object by passing the animal type as Lion
animal = animalFactory.GetAnimal("Lion");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.WriteLine();
// Get Cat Animal object by passing the animal type as Cat
animal = animalFactory.GetAnimal("Cat");
Console.WriteLine("Animal Type : " + animal.GetType().Name);
speakSound = animal.speak();
Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
Console.Read();