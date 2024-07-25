// See https://aka.ms/new-console-template for more information
using Creational.FluentInterface;

// 
FluentEmployee obj = new FluentEmployee();
obj.NameOfTheEmployee("Anurag Mohanty")
        .Born("10/10/1992")
        .WorkingOn("IT")
        .StaysAt("Mumbai-India");


//read data from employee object 
Console.WriteLine($"Employee Name: {obj.employee.FullName}, Birthday: {obj.employee.DateOfBirth}, Department: {obj.employee.Department},  Address: {obj.employee.Address}");

//use collection of FluentEmployee

//Not work! it has 3 counts, but all with same value
//Because this doesn't create new FluentEmployee to store the previous data, and the new value will replace the old values.
List<FluentEmployee> _fluentEmployees = new()  
{   
    obj.NameOfTheEmployee("May")
        .Born("10/10/1992")
        .WorkingOn("IT")
        .StaysAt("Mumbai-India"),

    obj.NameOfTheEmployee("Jack")
    .Born("10/10/1992")
    .WorkingOn("IT")
    .StaysAt("US"),

    obj.NameOfTheEmployee("Wong")
        .Born("10/10/1992")
        .WorkingOn("IT")
        .StaysAt("Seattle")
};

foreach (var item in _fluentEmployees)
{
    Console.WriteLine($"Employee Name: {item.employee.FullName}");
}
//Other method: use list collecton Employee
Console.WriteLine("");
Console.WriteLine("print Collection");
List<Employee> list = new()
{   //use collection initializer consumes lots of memory. 
    new Employee("Anurag Mohanty", Convert.ToDateTime("10/10/1992"), "IT", "Mumbai-India"),
    new Employee("Anurag Mohanty", Convert.ToDateTime("10/10/1992"), "IT", "US"),
    new Employee("Anurag Mohanty", Convert.ToDateTime("10/10/1992"), "IT", "Seattle")
};

foreach (var item in list)
{
    Console.WriteLine($"Employee Name: {item.FullName}, Birthday: {item.DateOfBirth}, Department: {item.Department},  Address: {item.Address}");
}

Console.Read();