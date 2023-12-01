// See https://aka.ms/new-console-template for more information

using BeatlesChat.Services;
using BeatlesChat.Services.Interfaces;
using BeatlesChat.Users;
using BeatlesChat.Users.Interfaces;
using Common;

IChatService<IUser> chatService = new ChatService();
ILogger consoleLogger = new ConsoleLogger();

IUser john = new User("John", consoleLogger, chatService);
IUser paul = new User("Paul", consoleLogger, chatService);
IUser george = new User("George", consoleLogger, chatService);
IUser ringo = new User("Ringo", consoleLogger, chatService);

IUser ringoFan = new User("RingoFan", consoleLogger, chatService);

john.SendMessage("Hello!", "Paul");
consoleLogger.EmptyLine();
paul.SendMessage("Hi!", "John");
consoleLogger.EmptyLine();
ringoFan.SendMessage("I am your biggest fan!", "Ringo");