using TextEditor.Enums;

namespace TextEditor.Services.Interfaces;

public interface IStrategyService
{
    void Run(FormatType strategy, string input);

}