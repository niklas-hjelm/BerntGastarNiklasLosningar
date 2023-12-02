// See https://aka.ms/new-console-template for more information

using Common;
using Common.HubCommunications;
using Network;
using Network.Clients;
using Network.Hubs;
using Network.Hubs.Interfaces;
using Network.Messages;

Console.WriteLine("Hello, World!");
ILogger consoleLogger = new ConsoleLogger();

IInternet internet = new Internet(new Address("","",""), consoleLogger);
ICountryHub countryHub = new CountryHub(new Address("Sweden","",""), internet);
ICountryHub countryHub2 = new CountryHub(new Address("USA","",""), internet);
ICountryHub countryHub3 = new CountryHub(new Address("Japan","",""), internet);
ICountryHub countryHub4 = new CountryHub(new Address("China","",""), internet);

ILocalHub localHub = new LocalHub(new Address("Sweden","Stockholm",""), countryHub);
ILocalHub localHub3 = new LocalHub(new Address("Japan","Tokyo",""), countryHub3);
ILocalHub localHub4 = new LocalHub(new Address("China","Beijing",""), countryHub4);
ILocalHub localHub5 = new LocalHub(new Address("China","Shanghai",""), countryHub4);
ILocalHub localHub2 = new LocalHub(new Address("USA","New York",""), countryHub2);

IClient computer = new Client(new Address("Sweden","Stockholm","Kista"), localHub, consoleLogger);
IClient computer2 = new Client(new Address("USA","New York","Manhattan"), localHub2, consoleLogger);
IClient computer3 = new Client(new Address("Japan","Tokyo","Shibuya"), localHub3, consoleLogger);
IClient computer4 = new Client(new Address("China","Beijing","Chaoyang"), localHub4, consoleLogger);
IClient computer5 = new Client(new Address("China","Shanghai","Pudong"), localHub5, consoleLogger);
IClient computer6 = new Client(new Address("Sweden","Stockholm","Solna"), localHub, consoleLogger);
IClient computer7 = new Client(new Address("USA","New York","Brooklyn"), localHub2, consoleLogger);

computer.Send(computer2.Address,"Hello!");
computer.Send(computer3.Address,"Hello!");
computer.Send(computer4.Address,"Hello!");

computer2.Send(computer.Address,"Hello!");

computer3.Send(computer.Address,"Hello!");

computer3.Send(computer2.Address,"Hello!");

computer4.Send(computer.Address,"Hello!");
