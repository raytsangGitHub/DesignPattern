// See https://aka.ms/new-console-template for more information

using Structural.Bridge.RefactoringGuru;
using Structural.Bridge.RefactoringGuru.Abstractions;
using Structural.Bridge.RefactoringGuru.Implementations;

Client client = new();

Abstraction abstraction;

abstraction = new Abstraction(new ConcreteImplementationA());
client.ClientCode(abstraction);
Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationB());

client.ClientCode(abstraction);
