using Common;
using StorageExercise.StorageTypes;
using StorageExercise.StorageTypes.Interfaces;
using StorageExercise.StorageContent;
using StorageExercise.StorageContent.Interfaces;

ILogger consoleLogger = new ConsoleLogger();

IStorage cloudStorage = new CloudStorage(consoleLogger, "NiklasDrömmar");
IStorage databaseStorage = new DatabaseStorage(consoleLogger, "NiklasBakficka");

IContent article = new ArticleContent("Article1");
IContent video = new VideoContent("Video1");

cloudStorage.Store(article);
cloudStorage.Store(video);

databaseStorage.Store(article);
databaseStorage.Store(video);