using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace capi.Tools;

public class DBService
{

    public IMongoDatabase database { get; private set; }

    public DBService(IOptions<DBSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        this.database = client.GetDatabase(settings.Value.DatabaseName);
    }
}