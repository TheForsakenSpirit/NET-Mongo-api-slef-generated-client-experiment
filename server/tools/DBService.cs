using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace capi.Tools;

public class DBService
{

    public IMongoDatabase database { get; private set; }

    public DBService(IOptions<DBSettings> settings)
    {
        MongoClientSettings mcs = MongoClientSettings.FromConnectionString(settings.Value.ConnectionString);
        mcs.LinqProvider = MongoDB.Driver.Linq.LinqProvider.V3;

        var client = new MongoClient(mcs);
        this.database = client.GetDatabase(settings.Value.DatabaseName);
    }
}