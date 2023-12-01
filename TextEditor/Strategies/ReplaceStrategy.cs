using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ReplaceStrategy : ITextStrategy
{
    public string Run(string input)
    {
        return input.Replace(" ", "");
    }
}