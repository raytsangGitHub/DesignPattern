// See https://aka.ms/new-console-template for more information
//Reference:
//https://www.youtube.com/watch?v=eGpiSMzCWTQ&list=PL_xlJum5pRdD_TEiWf9jK4Ozzg8VJyDSe&index=8 
//https://www.youtube.com/watch?v=r6Y0SmbufmU
using Creational.Singleton.ThreadSafe;
using Creational.Singleton.ThreadSafe.Lock;
//using delegate, a single thread 
//new Thread(() =>
//{
//    CustomerOrder order_1 = new();
//    order_1.PlaceOrder(1);
//}).Start();

//the above is same as, using lambda
Thread myThread = new Thread(() =>
{
    CustomerOrder order_1 = new();
    order_1.PlaceOrder(1);
});

myThread.Start();  //initiate the execution of the new thread. usig linq

//create the second instance, it should not started, because its locked. 
new Thread(() =>
{
    CustomerOrder order_2 = new();
    order_2.PlaceOrder(2);
}).Start();
Console.WriteLine();