using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CarCrudInfra
{
    public class MongoFactory<T>
    {
        private readonly IConfiguration configuration;

        public MongoFactory(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IMongoCollection<T> Connect(string CollectionName) 
        {
            var client = new MongoClient(configuration.GetConnectionString("Mongo"));
            var database = client.GetDatabase("cardb");
            return database.GetCollection<T>(CollectionName);
        }
    }
}
