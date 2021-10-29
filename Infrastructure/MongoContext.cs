using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class MongoContext : IMongoContext
    {
        public IMongoDatabase Database { get; }

        public MongoContext(IOptions<MongoSettings> settings)
        {
            var clientSettings = MongoClientSettings.FromConnectionString(settings.Value.ConnectionString);

            clientSettings.SslSettings = new SslSettings() { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };

            var client = new MongoClient(clientSettings);

            Database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<T> GetCollection<T>(string collection) =>
            Database.GetCollection<T>(collection);
    }
}
