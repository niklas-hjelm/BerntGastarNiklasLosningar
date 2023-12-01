// See https://aka.ms/new-console-template for more information

using Common;
using Network.Computers;
using Network.Computers.Interfaces;
using Network.Hubs;
using Network.Hubs.Interfaces;

Console.WriteLine("Hello, World!");

ILogger consoleLogger = new ConsoleLogger();
IHub hub = new NetworkHub("NiklasNät"); 
IComputer computer1 = new NetworkComputer(consoleLogger, "NiklasMegaMaskin");
IComputer computer2 = new NetworkComputer(consoleLogger, "NiklasLillaMaskin");
IComputer computer3 = new NetworkComputer(consoleLogger, "NiklasLaptop");

hub.Register(computer1);
hub.Register(computer2);
hub.Register(computer3);

hub.Broadcast("Woop", computer1.Name);
consoleLogger.EmptyLine();
hub.Send("Woop", computer2.Name, computer1.Name);