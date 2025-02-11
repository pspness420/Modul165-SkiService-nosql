using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace SkiServiceManagement.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        public MongoDbContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["MongodbDB:ConnectionString"]);
            _database = client.GetDatabase(configuration["MongoDB:DatabaseName"]);
        }
        public IMongoCollection<T> GetCollection<T> (string name)
            {
            return _database.GetCollection<T>(name);
            }
    }
}
