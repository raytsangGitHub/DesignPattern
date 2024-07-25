// See https://aka.ms/new-console-template for more information
using Creational.FactoryMethod;
using Creational.FactoryMethod.Creator;
using Creational.FactoryMethod.Product;

//Reference:  https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/

//Definition:   1) Define an interface for creating an object-The Factory, but lets the subclasses decide which class to instantiate.
//              2) The Factory method lets a class defer instantiation to subclasses.

//This is very interesting. A Subclass is instantiated, but referenced to the parent's abstract class. The bueaty of inheritance. which created a reference to Factory method with a return type of product- CreateProduct
//Client placed an order to make platinum product
ICreditCard creditCard = new PlatinumFactory().CreateProduct();   //New Idea. actually it's the LSP - subclass is substitutable with parent class.  AKA derefernecing. 

//My prove of OCP 
IExtendCreditCard ex = new CreditBalance();


//2) The Factory method lets a class defer instantiation to subclasses.
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType()); 
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
    Console.WriteLine($"Extended method, a prove of OCP: Credit Balance: {ex.GetCreditBalance()}");
}
else
{
    Console.Write("Invalid Card Type");
}
Console.WriteLine("");
Console.WriteLine("**** MoneyBackFactory ******");

creditCard = new MoneyBackFactory().CreateProduct();  //access the factory method.
if (creditCard != null)
{
    Console.WriteLine("Card Type : " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
    Console.WriteLine($"Extended method, a prove of OCP: Credit Balance: {ex.GetCreditBalance()}");
}
else
{
    Console.Write("Invalid Card Type");
}

//MyProof of concept: prove of abstract class, virtual and abstract class

var proofConcept = new ProofConcept().GetName("test");
//result: pass
Console.ReadLine();
