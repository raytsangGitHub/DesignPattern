// See https://aka.ms/new-console-template for more information
using Structural.Facade.RefactoringGuru.TheFacades;
using Structural.Facade.RefactoringGuru.TheSubSystems;

Subsystem1 subsystem1 = new();
Subsystem2 subsystem2 = new();

Facade facade = new(subsystem1, subsystem2);
Console.WriteLine(facade.Operation());

