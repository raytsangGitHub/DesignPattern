// See https://aka.ms/new-console-template for more information
using Behavioral.Strategy.Payment;

Console.WriteLine("Please Select Payment Type : CreditCard or DebitCard or Cash");
string PaymentType = Console.ReadLine();
//Console.WriteLine("Payment type is : " + PaymentType);
Console.WriteLine("\nPlease enter Amount to Pay : ");
double Amount = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Amount is : " + Amount);
PaymentContext context = new PaymentContext();

if ("CreditCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
{
    context.SetPaymentStrategy(new PayByCreditCard());
}
else if ("DebitCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
{
    context.SetPaymentStrategy(new PayByDebitCard());
}
else if ("Cash".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
{
    context.SetPaymentStrategy(new PayByCash());
}
context.Pay(Amount);
Console.ReadKey();