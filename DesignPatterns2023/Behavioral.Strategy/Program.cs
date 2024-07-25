// See https://aka.ms/new-console-template for more information
using Behavioral.Strategy;

//client decides the actual implementation to be use at runtime

CompressionContext ctx = new(new ZipCompression());  //new idea: passing in ZipCompression instance
ctx.CreateArchive("DotNetDesignPattern");


ctx.SetStrategy(new RarCompression());  //Switch to the new algorithm.
ctx.CreateArchive("DotNetDesignPattern");
Console.Read();


//The above example looks like a state pattern.

//Related patterns: State, Flyweight, template