using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class BaseRepo {
        public BaseRepo() {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            MongoClient client = new MongoClient(connectionString);
            var mongoDB = client.GetDatabase("NoSQL-Project");
            Console.WriteLine(mongoDB);
        }
    }
}
