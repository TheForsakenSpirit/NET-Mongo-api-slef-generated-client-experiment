using capi.Model;
using MongoDB.Driver;

namespace capi.Tools;

class DBServiceProvider<T> where T : ModelBase
{
    private DBService _service;
    private IMongoCollection<T> _collection;

    public DBServiceProvider(DBService service)
    {
        _service = service;
        _collection = _service.database.GetCollection<T>(typeof(T).Name);
    }

    public List<T> Get() =>
    _collection.Find(item => true).ToList();

    public List<T> Get(FilterDefinition<T> filter) =>
        _collection.Find(filter).ToList();

    public T GetOne(FilterDefinition<T> found) =>
        _collection.Find<T>(found).FirstOrDefault();

    public T Create(T item)
    {
        _collection.InsertOne(item);
        return item;
    }

    public void Update(FilterDefinition<T> found, UpdateDefinition<T> update) =>
        _collection.UpdateOne(found, update);

    public void Remove(FilterDefinition<T> found) =>
        _collection.DeleteOne(found);
}