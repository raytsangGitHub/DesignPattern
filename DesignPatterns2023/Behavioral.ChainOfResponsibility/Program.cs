// See https://aka.ms/new-console-template for more information
using Behavioral.ChainOfResponsibility;

ATM atm = new ATM();
Console.WriteLine("\n Requested Amount 4600");
atm.withdraw(4600);
Console.WriteLine("\n Requested Amount 1900");
atm.withdraw(1900);
Console.WriteLine("\n Requested Amount 100");
atm.withdraw(100);
