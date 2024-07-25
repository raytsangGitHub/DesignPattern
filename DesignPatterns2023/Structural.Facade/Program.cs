// See https://aka.ms/new-console-template for more information
using Structural.Facade.TheFacades;

IOrder order = new Order();
order.PlaceOrder();
IOrder extendOrder = new ExtendOrder();
extendOrder.PlaceOrder();
Console.Read();