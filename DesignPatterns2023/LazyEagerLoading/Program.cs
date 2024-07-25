// See https://aka.ms/new-console-template for more information
//Lazy loading is on-demand loading.
using LazyEagerLoading;


List<string> list = new List<string>();




Customer c = new();

Console.WriteLine(c.CustomerName);

foreach (Order _order in c.Orders)
{
    Console.WriteLine(_order.OrderNumber);

}

Console.ReadLine();
