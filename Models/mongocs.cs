using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace webapi.Models
{
    public class mongocs
    {
        private readonly IMongoDatabase _mongoDb;
        public mongocs()
        {
            var client = new MongoClient("mongodb+srv:" +
                "//admin1:<password>@webapi-e8w1p.azure.mongodb.net/test?retryWrites=true&w=majority");
            _mongoDb = client.GetDatabase("SarathDB");
        }
        public IMongoCollection<Users> Users
        {
            get
            {
                return _mongoDb.GetCollection<Users>("Users");
            }
        }

    }
}
