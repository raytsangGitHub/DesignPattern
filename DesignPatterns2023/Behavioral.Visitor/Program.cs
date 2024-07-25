// See https://aka.ms/new-console-template for more information
//Reference: https://www.oodesign.com/visitor-pattern
// 

using Behavioral.Visitor;

School school = new School();
var visitor1 = new Doctor("James");
school.PerformOperation(visitor1);
Console.WriteLine();