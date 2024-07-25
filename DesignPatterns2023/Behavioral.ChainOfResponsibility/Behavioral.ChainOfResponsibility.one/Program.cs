// See https://aka.ms/new-console-template for more information
//configure Chain of Responsibility
using Behavioral.ChainOfResponsibility.one;

IChain c1 = new NegativeProcessor();  //use LS principle. 
IChain c2 = new ZeroProcessor();
IChain c3 = new PositiveProcessor();

c1.setNext(c2);  //sets up the chain. 
c2.setNext(c3);

//calling chain of responsibility
c1.process(new Number(99));
c1.process(new Number(-30));
c1.process(new Number(0));
c1.process(new Number(100));