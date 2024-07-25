// See https://aka.ms/new-console-template for more information
//ref: https://refactoring.guru/replace-conditional-with-polymorphism
using Creational.WithoutFactoryDP;
using Creational.WithoutFactoryDP.Creator;

#region Without design pattern where client is tightly coupled to the product classes. violated the OCP
string cardType = "MoneyBack";
ICreditCard cardDetails = null!;

if (cardType == "MoneyBack")
{
    cardDetails = new MoneyBack();  //tight coupling between client and product, and extension
}
else if (cardType == "Titanium")
{
    cardDetails= new Titanium();
}
else if (cardType == "Platinum")
{
    cardDetails = new Platinum();
}

if (cardDetails != null)
{
    Console.WriteLine(" ***** Without facory design pattern  *****");
    Console.WriteLine("CardType : " + cardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}

// What is the Problem of the above code implementation?
// First, it violated the DI principle, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
// Secondly, violated the OC principle, if we add a new Credit Card, then also we need to modify the Main method by adding an extra if-else condition which not only overheads in the development but also in the testing process
#endregion


#region use factory DIP by introduce a new method GetCreditCard, so that the client and product class is decoupled. But the factory method still violate the OCP. 
// 

ICreditCard newCardDetails = CreditCardFactoryMehtod.GetCreditCard("Platinum");

if (newCardDetails != null)
{
    Console.WriteLine();
    Console.WriteLine(" ***** With facory design pattern  *****");
    Console.WriteLine("CardType : " + newCardDetails.GetCardType());
    Console.WriteLine("CreditLimit : " + newCardDetails.GetCreditLimit());
    Console.WriteLine("AnnualCharge :" + newCardDetails.GetAnnualCharge());
}
else
{
    Console.Write("Invalid Card Type");
}


#endregion

#region fix the factory method that violates the OCP (no more if...else in the factoryMethod)
// Steps for the fix:
// 1.  Introduce a creator asbract class (RefactorCreditCardFactoryMethod) with abstract method (GetCreditCardMethod) 
// 2. Create creator concret classes that inherits the abstract class RefactorCreditCardFactoryMethod
// 3. The concrete class will return the reference of product 
// 4. Ther reference then used to access the product objects.

Console.WriteLine();
Console.WriteLine(" ***** Refactor the factory method *****");
// this line can be modify if the dependency inject is apply to the contrucstor of each concrete creator class.
RefactorCreditCardFactoryMethod refactorCard = new MoneyBankFactory();


ICreditCard newRefactorCard = refactorCard.GetCreditCardMethod();

Console.WriteLine("CardType : " + newRefactorCard.GetCardType());
Console.WriteLine("CreditLimit : " + newRefactorCard.GetCreditLimit());
Console.WriteLine("AnnualCharge :" + newRefactorCard.GetAnnualCharge());
#endregion
Console.ReadLine();


