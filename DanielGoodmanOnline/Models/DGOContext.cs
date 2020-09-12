using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielGoodmanOnline.Models
{
    using DanielGoodmanOnline;
    using MongoDB.Driver;
    using System;
    public class DGOContext : IDGOContext
    {
        private readonly IMongoDatabase _db;
        public DGOContext(MongoDBConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }
        public IMongoCollection<Todo> Todos => _db.GetCollection<Todo>("Todos");
    }
}
