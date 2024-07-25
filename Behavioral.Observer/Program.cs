using Behavioral.Observer;

//reference: https://dotnettutorials.net/lesson/observer-design-pattern/

//Create a Product with Out Of Stock Status
Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");

//User Anurag will be created and user1 object will be registered to the subject
Observer user1 = new Observer("Anurag", RedMI);
//User Pranaya will be created and user1 object will be registered to the subject
Observer user2 = new Observer("Pranaya", RedMI);
//User Priyanka will be created and user3 object will be registered to the subject
Observer user3 = new Observer("Priyanka", RedMI);

Availability _availability = new(RedMI.ProductName, RedMI.ProductPrice, RedMI.ProductAvailability);
Console.WriteLine("Red MI Mobile current state : " + _availability.getAvailability());
Console.WriteLine();
// Now product is available
_availability.setAvailability("Available");
Console.Read();
