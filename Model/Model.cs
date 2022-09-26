namespace capi.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class ModelBase
{

    [BsonId]
    private ObjectId? id { get; set; } = null;

    public ModelBase()
    {
        this.id = ObjectId.GenerateNewId();
    }


}