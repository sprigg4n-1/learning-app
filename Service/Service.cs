using MongoDB.Driver;

public class Service : IService
{
  private MongoClient _client;
  private IMongoDatabase _database;
  private IMongoCollection<WordsTheme> _wordsThemes;

  public Service()
  {
    _client = new MongoClient("mongodb://localhost:27017");
    _database = _client.GetDatabase("app_words");
    _wordsThemes = _database.GetCollection<WordsTheme>("words");
  }

  public List<WordsTheme> GetWordsThemes(String levelToFind)
  {
    return _wordsThemes.Find(x => x.level.Equals(levelToFind.ToUpper())).ToList();
  }

  public WordsTheme GetWordsThemesById(String id)
  {
    WordsTheme theme = _wordsThemes.Find(x => x.id == id).FirstOrDefault();
    return theme;
  }
}