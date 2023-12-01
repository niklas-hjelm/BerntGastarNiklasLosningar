using Common;
using StorageExercise.StorageContent.Interfaces;
using StorageExercise.StorageTypes.Interfaces;

namespace StorageExercise.StorageTypes.Abstracts;

public abstract class Storage(ILogger logger, string name) : IStorage
{
    public string Name { get; set; } = name;
    public abstract void Store(IContent content);
}