// See https://aka.ms/new-console-template for more information
using Behavioral.Mediator;

IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();  //LSP

AbstractUser Ram = new ConcreteUser(facebookMediator, "Ram");
AbstractUser Dave = new ConcreteUser(facebookMediator, "Dave");
AbstractUser Smith = new ConcreteUser(facebookMediator, "Smith");
AbstractUser Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
AbstractUser Sam = new ConcreteUser(facebookMediator, "Sam");
AbstractUser Pam = new ConcreteUser(facebookMediator, "Pam");
AbstractUser Anurag = new ConcreteUser(facebookMediator, "Anurag");
AbstractUser John = new ConcreteUser(facebookMediator, "John");

facebookMediator.RegisterUser(Ram);
facebookMediator.RegisterUser(Dave);
facebookMediator.RegisterUser(Smith);
facebookMediator.RegisterUser(Rajesh);
facebookMediator.RegisterUser(Sam);
facebookMediator.RegisterUser(Pam);
facebookMediator.RegisterUser(Anurag);
facebookMediator.RegisterUser(John);

Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
Console.WriteLine();
Rajesh.Send("What is Design Patterns? Please explain ");
Console.Read();