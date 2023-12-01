using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ToUpperStrategy : ITextStrategy
{
    public string Run(string input)
    {
        return input.ToUpper();
    }
}