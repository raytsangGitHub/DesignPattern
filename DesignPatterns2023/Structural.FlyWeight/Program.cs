﻿// See https://aka.ms/new-console-template for more information
using Structural.FlyWeight;


Console.WriteLine("\n Red color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");  //calling static method, 
    circle.SetColor("Red");
    circle.Draw();
}
Console.WriteLine("\n Green color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
Console.WriteLine("\n Blue color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}
Console.WriteLine("\n Orange color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Orange");
    circle.Draw();
}
Console.WriteLine("\n Black color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Black");
    circle.Draw();
}
Console.ReadKey();