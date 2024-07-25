// See https://aka.ms/new-console-template for more information

using Creational.FactoryMethod.Notification;
using Creational.FactoryMethod.Notification.Creator;

var notificationSystem = new NotificationSystem();
// For a user who prefers email notifications:
notificationSystem.NotifyUser(new EmailNotifierFactory(), "This is an email notification!");
// For a user who prefers SMS notifications:
notificationSystem.NotifyUser(new SMSNotifierFactory(), "This is an SMS notification!");
// For a user who prefers push notifications:
notificationSystem.NotifyUser(new PushNotifierFactory(), "This is a push notification!");
Console.ReadKey();


//For more example: https://dotnettutorials.net/lesson/real-time-examples-of-factory-method-design-pattern-in-csharp/
//Document Format Converters
//Report Generators
//Payment Gateway Integration
//Logistics Application