using BerntGästarNiklasLösningar1.Interfaces;

namespace BerntGästarNiklasLösningar1.Abstracts;

public abstract class Calculator : ICalculator
{
    public abstract decimal CalculatePrice(IProduct product);
}