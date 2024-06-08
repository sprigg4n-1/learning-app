
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


public class User
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string? id { get; set; }

  public string nickname { get; set; }

  public string email { get; set; }

  public string password { get; set; }

  [BsonElement("words")]
  [JsonPropertyName("words")]
  public MWord[] words { get; set; }

  [BsonElement("tasks")]
  [JsonPropertyName("tasks")]
  public UserTask[] tasks { get; set; }
}

public class UserTask
{
  public int id { get; set; }
  public DateTime date { get; set; }
  public string task { get; set; }
  public bool done { get; set; }
  public bool important { get; set; }
}
