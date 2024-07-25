// See https://aka.ms/new-console-template for more information
using Structural.Bridge.Abstraction;
using Structural.Bridge.Implementor;
using Structural.Bridge;

// *** Allows the separation of an abstract interface from its implementation.

// Except for the initialization phase, where an Abstraction object gets i.e. SonyRemoteControl or SamsungRemoteControl
// linked with a specific Implementation object i.e. new SonyLedTv() or new SamsungLedTv(), 
// the client code should only depend on the Abstraction class i.e. SonyRemoteControl or SamsungRemoteControl. 


AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());  //inject the implementor
sonyRemoteControl.SwitchOn();
sonyRemoteControl.SetChannel(101);
sonyRemoteControl.SwitchOff();
Console.WriteLine();
//LSP:
AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());

samsungRemoteControl.SwitchOn();
samsungRemoteControl.SetChannel(202);
samsungRemoteControl.SwitchOff();
Console.ReadKey();