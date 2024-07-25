// See https://aka.ms/new-console-template for more information
using DeepAndShallowCopyDemo2;

Company c1 = new Company(548, "GeeksforGeeks", "Sandeep Jain");
//perform shallow copy

Company cloned = (Company)c1.Shallowcopy();
Console.WriteLine($"{cloned.GBRank.ToString()}, {cloned.desc.CompanyName}, {cloned.desc.Owner}");

//now c1 is the original object, and shallowcopy is cloned object
//test cases shallowcopy:
Console.WriteLine($"case1: what are the orignal object value and the cloned object value: {c1.GBRank} vs {cloned.GBRank} ");
c1.GBRank = 333;
Console.WriteLine($"case2: Change value type c1, verify c1 vs cloned are difference value: {c1.GBRank} vs {cloned.GBRank}");
cloned.desc.CompanyName = "GFG";
Console.WriteLine($"case3: Change referenc type c1, verify c1 and cloned should be same value: {c1.desc.CompanyName} vs {cloned.desc.CompanyName}");

//Following line won't print out the result, it needs string concatination +
//Console.WriteLine(shallowcopy.GBRank.ToString(), shallowcopy.desc.CompanyName, shallowcopy.desc.Owner);

// Performing Deep copy                             
Company c2 = (Company)c1.DeepCopy();

Console.WriteLine("Before Changing: ");

// Before changing the value of 
// c2 GBRank and CompanyName
Console.WriteLine(c1.GBRank);
Console.WriteLine(c2.GBRank);
Console.WriteLine(c2.desc.CompanyName);
Console.WriteLine(c1.desc.CompanyName);

Console.WriteLine("\nAfter Changing: ");

// changing the value of c2 
// GBRank and CompanyName
c2.GBRank = 59;
c2.desc.CompanyName = "GFG";

// After changing the value of
// c2 GBRank and CompanyName
Console.WriteLine(c1.GBRank);
Console.WriteLine(c2.GBRank);
Console.WriteLine(c2.desc.CompanyName);
Console.WriteLine(c1.desc.CompanyName);