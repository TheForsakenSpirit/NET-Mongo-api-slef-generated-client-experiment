using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace capi.Model;

public class Notification : ModelBase
{
    [BsonElement("key")]
    public string Key { get; set; } = "";

    [BsonElement("date")]
    public DateTime Date { get; set; }

    [BsonElement("message")]
    public string? Message { get; set; }

    [BsonElement("toDoKey")]
    public string? ToDoKey { get; set; }

    [BsonElement("userKey")]
    public string? UserKey { get; set; }
}