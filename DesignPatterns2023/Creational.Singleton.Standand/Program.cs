// See https://aka.ms/new-console-template for more information
//Reference:
//https://www.youtube.com/watch?v=eGpiSMzCWTQ&list=PL_xlJum5pRdD_TEiWf9jK4Ozzg8VJyDSe&index=8 
//https://www.youtube.com/watch?v=r6Y0SmbufmU
using Creational.Singleton.Standand;

//CustomerOrder _customerOrder_1 = new();
//_customerOrder_1.PlaceOrder(1);

//CustomerOrder _customerOrder_2 = new();
//_customerOrder_2.PlaceOrder(2);

////Note: the stand design will break in the multiple threaded implementation. see threadSafe project for the fix(using locking).
////proof:
//Console.WriteLine("");
Console.WriteLine("proof of multiple thread not work on the standard implementation.");
Console.WriteLine("the constructor is called twice.");
Console.WriteLine("");
new Thread(() =>
{
    CustomerOrder order_1 = new();
    order_1.PlaceOrder(1);
}).Start();

new Thread(() =>
{
    CustomerOrder order_2 = new();
    order_2.PlaceOrder(2);
}).Start();
Console.ReadKey();



