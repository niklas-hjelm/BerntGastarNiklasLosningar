using Common;
using StorageExercise.StorageTypes;
using StorageExercise.StorageTypes.Interfaces;
using StorageExercise.StorageContent;
using StorageExercise.StorageContent.Interfaces;

ILogger consoleLogger = new ConsoleLogger();

IStorage cloudStorage = new CloudStorage(consoleLogger, "NiklasDrömmar");
IStorage fileStorage = new FileStorage(consoleLogger, "NiklasBakficka");

IContent article = new ArticleContent("Article1");
IContent video = new PictureContent("Picture1");

cloudStorage.Store(article);
cloudStorage.Store(video);

fileStorage.Store(article);
fileStorage.Store(video);