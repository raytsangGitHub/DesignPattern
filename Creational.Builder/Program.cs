// See https://aka.ms/new-console-template for more information
using System.IO;
using Creational.Builder;

//Separate the construction of a complex object from its representation so that the same construction process can create different representations.

//ConcreteBuilder: Concrete classes that will create the complex Product. this will keep track of what Product it has created i.e. assembled what parts and this will be used by the client to get the Product object.
//Builder: This is the interface for creating the actual products
//Director: This is the Client code that will specify the parts needs to be put tegether to to create the actual concrete Product.
//Product: This is the object that will be created by assembling many parts.


Report report;
ReportDirector reportDirector = new ReportDirector();
// Construct and display Reports
PDFReport pdfReport = new PDFReport();
report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine("-------------------");
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();

Console.ReadKey();