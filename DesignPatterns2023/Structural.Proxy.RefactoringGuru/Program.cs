// See https://aka.ms/new-console-template for more information

using Structural.Proxy.RefactoringGuru;
using Structural.Proxy.RefactoringGuru.Proxies;
using Structural.Proxy.RefactoringGuru.RealServices;
using System.Net.WebSockets;

Client client = new();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealService realService = new RealService();
client.ClientCode(realService);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy1 proxy = new Proxy1(realService);
client.ClientCode(proxy);
