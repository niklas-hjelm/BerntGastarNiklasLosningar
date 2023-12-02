// See https://aka.ms/new-console-template for more information

using Common;
using Network;
using Network.Clients;
using Network.Clients.Interfaces;
using Network.Hubs;
using Network.Hubs.Interfaces;
using Network.Messages;

Console.WriteLine("Hello, World!");
ILogger consoleLogger = new ConsoleLogger();

IInternet internet = new Internet(new Address("","",""), consoleLogger);
ICountryHub countryHub = new CountryHub(new Address("Sweden","",""), internet);
ICountryHub countryHub2 = new CountryHub(new Address("USA","",""), internet);
ILocalHub localHub = new LocalHub(new Address("Sweden","Stockholm",""), countryHub);
ILocalHub localHub2 = new LocalHub(new Address("USA","New York",""), countryHub2);

IClient computer = new Client(new Address("Sweden","Stockholm","Kista"), localHub, consoleLogger);
IClient computer2 = new Client(new Address("USA","New York","Manhattan"), localHub2, consoleLogger);

computer.Send(new Address("USA","New York","Manhattan"),"Hello!");