using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ToUpperStrategy : ITextStrategy
{
    public string Execute(string input)
    {
        return input.ToUpper();
    }
}