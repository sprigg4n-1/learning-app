using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class WordsTheme
{
  [BsonRepresentation(BsonType.ObjectId)]
  public string id { get; set; } = ObjectId.GenerateNewId().ToString();
  public string level { get; set; }
  public string theme { get; set; }
  public MWord[] words { get; set; }
}

public class MWord
{
  public string sentence { get; set; }
  public string translate { get; set; }
  public string type { get; set; }
  public string word { get; set; }

}