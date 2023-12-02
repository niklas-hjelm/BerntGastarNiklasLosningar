namespace Common.Strategy;

public interface IStrategy<out T, in TU>
{
    T Run(TU input);
}