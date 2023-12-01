using Common;
using StorageExercise.StorageContent.Interfaces;
using StorageExercise.StorageTypes.Abstracts;

namespace StorageExercise.StorageTypes;

public class CloudStorage(ILogger logger, string name) : Storage(logger, name)
{
    public override void Store(IContent content)
    {
        logger.Log($"Storing {content.Name} in cloud {Name}");
    }
}