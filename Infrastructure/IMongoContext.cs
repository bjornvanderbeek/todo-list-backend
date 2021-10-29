using MongoDB.Driver;

namespace Infrastructure
{
    public interface IMongoContext
    {
        IMongoDatabase Database { get; }

        IMongoCollection<T> GetCollection<T>(string collection);
    }
}