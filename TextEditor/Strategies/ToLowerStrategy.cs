using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ToLowerStrategy : ITextStrategy
{
    public string Run(string input)
    {
        return input.ToLower();
    }
}