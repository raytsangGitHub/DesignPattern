// See https://aka.ms/new-console-template for more information
using Creational.Prototype;

// Creating an Instance of Permanent Employee Class
Employee emp1 = new PermanentEmployee()
{
    Name = "Chuck",
    Department = "IT",
    Type = "Permanent",
    Salary = 100000
};

//Creating a Clone of the above Permanent Employee
Employee emp2 = emp1.ShallowCopy();
emp1.ShowDetails();
Employee emp2deep = emp1.DeepCopy();
emp2deep.ShowDetails();
// Changing the Name and Department Property Value of emp2 instance, 
// will not change the Name and Department Property Value of the emp1 instance
emp2.Name = "Pranaya";
emp2.Department = "HR";


emp2.ShowDetails();

Employee emp2DeepClone = emp2.DeepCopy();

// Creating an Instance of Temporary Employee Class
Employee emp3 = new TemporaryEmployee()
{
    Name = "Preety",
    Department = "HR",
    Type = "Temporary",
    FixedAmount = 200000
};
//Creating a Clone of the above Temporary Employee
Employee emp4 = emp3.ShallowCopy();
// Changing the Name and Department Property Value of emp4 instance, 
// will not change the Name and Department Property Value of the emp3 instance
emp4.Name = "Priyanka";
emp4.Department = "Sales";
emp3.ShowDetails();
emp4.ShowDetails();

Console.Read();