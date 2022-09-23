using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace capi.Model;

public class User : ModelBase
{
    [BsonElement("key")]
    public string Key { get; set; } = "";

    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("email")]
    public string? Email { get; set; }
}