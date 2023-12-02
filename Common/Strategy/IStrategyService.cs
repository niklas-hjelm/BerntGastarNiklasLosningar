namespace Common.Strategy;

public interface IStrategyService<in T, out TU, in TUu, in TUUu>
    where T : IStrategy<TU, TUu>
    where TUUu : Enum
{
    void AddStrategy(T strategy, TUUu strategyType);
    TU Run(TUu input);

    void SetStrategy(TUUu strategy);
}