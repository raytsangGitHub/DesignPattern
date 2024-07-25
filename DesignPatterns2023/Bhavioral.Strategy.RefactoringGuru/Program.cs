﻿// See https://aka.ms/new-console-template for more information
using Behavioral.Strategy.RefactoringGuru.Context;
using Behavioral.Strategy.RefactoringGuru.Strategy;

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new StrategyA());
context.DoSomeBusinessLogic();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new StrategyB());
context.DoSomeBusinessLogic();
