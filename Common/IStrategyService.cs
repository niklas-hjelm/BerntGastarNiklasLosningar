namespace Common;

public interface IStrategyService<T, TU, TUu, TUUu> 
    where T : IStrategy<TU, TUu> 
    where TUUu : Enum
{
    void AddStrategy(T strategy, TUUu strategyType);
    TU Run(TUu input);

    void SetStrategy(TUUu strategy);
}