// See https://aka.ms/new-console-template for more information
using Structural.Decorator.RefactoringGuru;
using Structural.Decorator.RefactoringGuru.ConcreteComponents;
using Structural.Decorator.RefactoringGuru.ConcreteDecorators;

Client client = new();

ConcreteComponent simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
//calling the default component
client.ClientCode(simple);
Console.WriteLine();

// ...as well as decorated ones.
//
// Note how decorators can wrap not only simple components but the
// other decorators as well.
ConcreteDecoratorA decoratorA = new ConcreteDecoratorA(simple); //wrapping
ConcreteDecoratorB decoratorB = new ConcreteDecoratorB(decoratorA);
ConcreteDecoratorC concreteDecoratorC = new ConcreteDecoratorC(decoratorB);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(concreteDecoratorC);
