using TextEditor.Strategies.Interfaces;

namespace TextEditor.Strategies;

public class ReplaceStrategy : ITextStrategy
{
    public string Execute(string input)
    {
        return "Hej";
    }
}