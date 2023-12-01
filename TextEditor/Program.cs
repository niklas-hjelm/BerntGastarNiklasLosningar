using Common;
using TextEditor.Enums;
using TextEditor.Services;
using TextEditor.Services.Interfaces;

Console.WriteLine("Hello, World!");

ILogger logger = new ConsoleLogger();
ITextStrategyService strategyService = new StrategyService(logger, FormatType.ToUpper);

Console.WriteLine(strategyService.Run("Hello, World!"));
strategyService.SetStrategy(FormatType.ToLower);
Console.WriteLine(strategyService.Run("Hello, World!"));
strategyService.SetStrategy(FormatType.Replace);
Console.WriteLine(strategyService.Run("Hello, World!"));