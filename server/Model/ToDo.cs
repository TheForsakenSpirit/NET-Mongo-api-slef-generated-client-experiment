using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace capi.Model;

public class ToDo : ModelBase
{
    [BsonElement("key")]
    public string Key { get; set; } = "";

    [BsonElement("date")]
    public DateTime Date { get; set; }

    public string? Summary { get; set; }

    [BsonElement("userKey")]
    public string? userKey { get; set; }
}
