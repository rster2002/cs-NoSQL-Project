using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DAL {
    public abstract class BaseRepo<T>: IRepo<T> where T : IEntity {
        private IMongoDatabase mongoDatabase;
        private IMongoCollection<T> collection;

        public BaseRepo(string collectionName) {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            MongoClient client = new MongoClient(connectionString);
            mongoDatabase = client.GetDatabase("NoSQL-Project");
            collection = mongoDatabase.GetCollection<T>(collectionName);
        }

        public IEnumerable<T> GetAll() {
            return collection.Find(item => true).ToList();
        }

        public IEnumerable<T> Get(FilterDefinition<T> filter) {
             return collection.Find(filter).ToList();
        }

        public T Get(string id) {
            return collection.Find(item => item.Id == id).FirstOrDefault();
        }

        public void Add(T entity) {
            collection.InsertOne(entity);
        }

        public void Update(T entity) {
            collection.ReplaceOne(item => item.Id == entity.Id, entity);
        }

        public void AddMultiple(T[] entities) {
            collection.InsertMany(entities);
        }

        public void Delete(string id) {
            collection.DeleteOne(id);
        }

        public void Delete(T entity) {
            Delete(entity.Id);
        }

        public void Delete(Func<T, bool> func) {
            throw new NotImplementedException();
        }
    }
}
