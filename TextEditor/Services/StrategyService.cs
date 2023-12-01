using Common;
using TextEditor.Enums;
using TextEditor.Services.Interfaces;
using TextEditor.Strategies.Interfaces;

namespace TextEditor.Services;

public class StrategyService(ILogger logger) : IStrategyService
{
    private readonly Dictionary<FormatType, ITextStrategy> _strategies = new()
    {
        { FormatType.ToUpper, new ToUpperStrategy() },
        { FormatType.ToLower, new ToLowerStrategy() },
        { FormatType.Replace, new ReplaceStrategy() }
    };

    public void Run(FormatType strategy, string input)
    {
        logger.Log($"Running strategy {strategy}");
        var result = _strategies[strategy].Execute(input);
        logger.Log($"Result: {result}");
    }
}