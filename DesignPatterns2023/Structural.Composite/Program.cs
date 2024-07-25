// See https://aka.ms/new-console-template for more information
//Creating Leaf Objects
using Structural.Composite.Component;
using Structural.Composite.Composite;

//Creating Leaf Objects
IComponent hardDisk = new Leaf("Hard Disk", 2000); 
IComponent ram = new Leaf("RAM", 3000);
IComponent cpu = new Leaf("CPU", 2000);
IComponent mouse = new Leaf("Mouse", 2000);
IComponent keyboard = new Leaf("Keyboard", 2000);

//Creating composite objects *** create nodes
Composite motherBoard = new Composite("Peripherals");
Composite cabinet = new Composite("Cabinet");
Composite peripherals = new Composite("Peripherals");
Composite computer = new Composite("Computer");

//Creating tree structure
//Adding CPU and RAM in Mother board
motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);

//Adding mother board and hard disk in Cabinet  *** this is level two node
cabinet.AddComponent(motherBoard);  //the composite node
cabinet.AddComponent(hardDisk);  //The leaf node

//Adding mouse and keyborad in peripherals, *** this is level two node
peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);
//Adding cabinet and peripherals in computer
computer.AddComponent(cabinet);  //*** Computer is the root node
computer.AddComponent(peripherals);  //
//To display the Price of Computer
computer.DisplayPrice();
Console.WriteLine();
//To display the Price of Keyboard
keyboard.DisplayPrice();
Console.WriteLine();
//To display the Price of Cabinet
cabinet.DisplayPrice();


//How is the tree structure constructed?
// By adding component in a tree fasion
//The fundamental idea is if you perform some operation on the leaf object then the same operation should be performed on the composite objects. For example, if I am able to get the price of a Mouse, then I should be able to get the Price of Peripherals and even I should be able to get the Price of the Computer object. 
Console.Read();