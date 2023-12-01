using StorageExercise.StorageContent.Interfaces;

namespace StorageExercise.StorageTypes.Interfaces;

public interface IStorage
{
    string Name { get; set; }
    void Store(IContent content);
}