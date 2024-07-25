using Creational.Builder.RefactoringGuru.ConcreteBuilder;
using Creational.Builder.RefactoringGuru.Directors;

// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.

ConcreteBuilder builder = new();  //client dependent -----> on builder  
Director director = new(builder);  //client associates the director

//** two ways passing the builder reference. through property or constructor.
//director.Builder = builder;  //new: set director property

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct(); //access method in director
Console.WriteLine(builder.GetProduct().ListParts()); //display the products

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListParts());

//Remember, the Builder pattern can be used without a Director class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());