// See https://aka.ms/new-console-template for more information
using Microsoft.Practices.Unity;
using Creational.Singleton.UnityContainer;
//use containers to create singleton

var container = new UnityContainer();
//container.RegisterType<SingletonLogger>();
container.RegisterType<ISingletonLogger, SingletonLogger>(new ContainerControlledLifetimeManager());

CustomerOrder _customerOrder_1 = container.Resolve<CustomerOrder>();
_customerOrder_1.PlaceOrder(1);
CustomerOrder _customerOrder_2 = container.Resolve<CustomerOrder>();
_customerOrder_2.PlaceOrder(2);

//Note: the stand design will break in the multiple threaded implementation. see threadSafe project for the fix.
//proof:
Console.WriteLine("");

//reference: https://www.youtube.com/watch?v=eGpiSMzCWTQ&list=PL_xlJum5pRdD_TEiWf9jK4Ozzg8VJyDSe&index=8 