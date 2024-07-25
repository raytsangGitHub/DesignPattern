// See https://aka.ms/new-console-template for more information

//Definition: A Virtual Proxy is a placeholder for objects which are expensive to create. The real object is only created when a client requests or accesses an object for the first time.
using Structural.Proxy.VirtualProxy;

IImage Image1 = new ProxyImage("Tiger Image");

Console.WriteLine("Image1 calling DisplayImage first time :");
Image1.DisplayImage(); // loading necessary
Console.WriteLine("Image1 calling DisplayImage second time :");
Image1.DisplayImage(); // loading unnecessary
Console.WriteLine("Image1 calling DisplayImage third time :");
Image1.DisplayImage(); // loading unnecessary
Console.WriteLine();
IImage Image2 = new ProxyImage("Lion Image");
Console.WriteLine("Image2 calling DisplayImage first time :");
Image2.DisplayImage(); // loading necessary
Console.WriteLine("Image2 calling DisplayImage second time :");
Image2.DisplayImage(); // loading unnecessary
Console.ReadKey();