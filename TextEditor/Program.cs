using Common;
using TextEditor.Enums;
using TextEditor.Services;
using TextEditor.Services.Interfaces;

Console.WriteLine("Hello, World!");

ILogger logger = new ConsoleLogger();
IStrategyService strategyService = new StrategyService(logger);

strategyService.Run(FormatType.ToUpper, "Hello, World!");
strategyService.Run(FormatType.ToLower, "Hello, World!");
strategyService.Run(FormatType.Replace, "Hello, World!");