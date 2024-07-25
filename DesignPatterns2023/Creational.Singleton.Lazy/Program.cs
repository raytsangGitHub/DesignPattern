// See https://aka.ms/new-console-template for more information
using Creational.Singleton.Lazy;

LazySingleton res = LazySingleton.GetInstance("hello");
LazySingleton res2 = LazySingleton.GetInstance("test");

//check if singleton works. should not be able to instantiate. ctor is private
// LazySingleton ls = new();


Console.WriteLine($"Lazy singleton: {res}");  

