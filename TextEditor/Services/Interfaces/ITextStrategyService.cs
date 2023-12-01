using Common;
using TextEditor.Enums;
using TextEditor.Strategies.Interfaces;

namespace TextEditor.Services.Interfaces;

public interface ITextStrategyService : IStrategyService<ITextStrategy, string, string, FormatType>
{
}