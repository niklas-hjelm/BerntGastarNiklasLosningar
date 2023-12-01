using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ToLowerStrategy : ITextStrategy
{
    public string Execute(string input)
    {
        return input.ToLower();
    }
}