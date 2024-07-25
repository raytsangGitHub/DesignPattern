// See https://aka.ms/new-console-template for more information
using Creational.Singleton;
using Creational.Singleton.LazyEagerLoading;

//Eager loading or non-deferred loading
Parallel.Invoke
    (
        () => CustomerOrder.PrintTeacherDetails(),
        () => CustomerOrder.PrintStudentdetails()
    );

//Lazy loading or deferred loading


Console.WriteLine("**** Lazy loading *****");
Parallel.Invoke
    (
        () => CustomerOrder.PrintTeacherDetails(),
        () => CustomerOrder.PrintStudentdetails()
    );

Console.ReadLine();

