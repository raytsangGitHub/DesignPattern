// See https://aka.ms/new-console-template for more information
using Structural.Proxy;
//Protection Proxy implementation

Console.WriteLine("Client passing employee with Role Developer to folderproxy");
Employee emp1 = new("Cat", "Cat1", "Animal");

SharedFolderProxy _sharedFolderProxy = new(emp1);
_sharedFolderProxy.PerformRWOperations();

Console.WriteLine();

Employee emp2 = new("Cat", "Cat1", "CEO");

SharedFolderProxy _sharedFolderProxy1 = new(emp2);
_sharedFolderProxy1.PerformRWOperations();