using StorageExercise.StorageContent.Interfaces;

namespace StorageExercise.StorageContent.Abstracts;

public abstract class Content(string name) : IContent
{
    public virtual string Name { get; } = name;
}