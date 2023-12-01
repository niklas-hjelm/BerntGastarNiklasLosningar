using Common;
using TextEditor.Enums;
using TextEditor.Services.Interfaces;
using TextEditor.Strategies;
using TextEditor.Strategies.Interfaces;

namespace TextEditor.Services;

public class StrategyService(ILogger logger, FormatType strategy) : ITextStrategyService
{
    private readonly Dictionary<FormatType, ITextStrategy> _strategies = new ()
        {
            { FormatType.ToUpper, new ToUpperStrategy() },
            { FormatType.ToLower, new ToLowerStrategy() },
            { FormatType.Replace, new ReplaceStrategy() }
        };

    private FormatType _strategy = strategy;

    public void AddStrategy(ITextStrategy strategy, FormatType strategyType)
    {
        _strategies.Add(strategyType, strategy);
    }

    public string Run(string input)
    {
        logger.Log("Running strategy: " + _strategy);
        return _strategies[_strategy].Run(input);
    }

    public void SetStrategy(FormatType strategy)
    {
        _strategy = strategy;
    }
}