// See https://aka.ms/new-console-template for more information
using Creational.SimpleFactory;

// Factory Design Pattern states that A factory is an object which is used for creating other objects.

//Determine card instance by calling the static method in the factory
ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");   

if (cardDetails != null)
{
    Console.WriteLine("CardType : " + cardDetails.GetCardType()); //Accessing the Property of each card
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}
Console.ReadLine();

//Problem sample factory pattern:
//1. The client is coupled with the factory object. which violated OCP, fix with factory method.