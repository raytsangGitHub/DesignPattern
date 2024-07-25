// See https://aka.ms/new-console-template for more information

using DeepAndShallowCopy;


//Difference between shallow and deep copy
// In the case of Shallow copy, it will create the clone object from the existing object and then copy the value type fields of the existing object to the new stack.
// But for the reference type property, it only copy the reference, not the actual object itself. Therefore the existing and clone objects refer to the same memory location in the case of reference type.

// In the case of Deep Copy, it will create the clone object from the existing object and then copy the fields of the existing object to the newly created clone object.
// If the field is a value type, then a bit-by-bit copy(to the stack) of the field will be performed.
// If the field is a reference type, then a new copy of the referred object is going to be created. That means, unlike the Shallow Copy, in the case of Deep Copy, both existing and clone objects have different memory locations for the reference type properties.
//In short: both lazy and deep value type are same.
// but in reference type copy, lazy copys the reference of the existing object, where deep copy creates a new object with new memory address.
//For static need not consider static members or static fields. The reason is that static objects are stored in a shared memory location and you have one memory location allocated for them per application domain. 

AutoModel auto1 = new()
{
    Make = "Honda",
    Model = "Accord XL",
    Year = "2023",
    DealerAddress =new Address() { address = "us address"}

};


//** Demo Shallow copy for value type
int year = 2023;
int newYear = year;

//** Demo Shallow copy for reference type

Console.WriteLine(" ** Demo Shallow copy for reference type");
Console.WriteLine(" ** Demo Shallow copy for value type/n");
AutoModel auto2 = auto1.GetShallowClone();

//prove: both auto1 and auto2 are update, they both pointing to the same memory location or same instance.
auto2.Make = "Toyota";

//** Demo Deep copy value type
Console.WriteLine(" ** Demo Deep copy value type/n");



//** Demo Deep copy for reference type
Console.WriteLine(" ** Demo Deep copy for reference type");
//assign value to Address object property: two ways to do the assignment: 1) in object initialze 2)as the following line
//auto1.DealerAddress = new Address() { address = "US dealer"};
AutoModel auto3 = auto1.GetDeepClone();
auto3.DealerAddress = new Address() { address = "new address" };
Console.WriteLine($"Deep copy: {auto1.DealerAddress.address} vs {auto3.DealerAddress.address}");


Console.ReadKey();