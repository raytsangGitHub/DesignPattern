// See https://aka.ms/new-console-template for more information
using Behavioral.Iterator.Aggregate;
using Behavioral.Iterator.IteratorNS;

// Build a collection
ConcreteCollection collection = new();

collection.AddEmployee(new Employee("Anurag", 100));
collection.AddEmployee(new Employee("Pranaya", 101));
collection.AddEmployee(new Employee("Santosh", 102));
collection.AddEmployee(new Employee("Priyanka", 103));
collection.AddEmployee(new Employee("Abinash", 104));
collection.AddEmployee(new Employee("Preety", 105));

//new: instantiate CreateIterator this way. Because CreateIterator is same type as abstractIterator.
AbstractIterator iterator = collection.CreateIterator();

//looping iterator      
Console.WriteLine("Iterating over collection:");

for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
}
