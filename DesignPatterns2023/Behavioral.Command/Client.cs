// See https://aka.ms/new-console-template for more information
using Behavioral.Command;


//Request commands 
Document document = new();  //client associate the receiver object. associate means create an instance. 
ICommand openCommand = new OpenCommand(document); // Concrete object depends on commandClinet object. Relationship in the instance level.
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);

//Client associate with Receiver object . 
MenuOptions menu = new(openCommand, saveCommand, closeCommand);

// Execute methods
menu.ClickOpen();
menu.ClickSave();
menu.ClickClose();