using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
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

        public long Count(Expression<Func<T, bool>> expression) {
            return collection.CountDocuments(expression);
        }

        public IEnumerable<T> GetAll() {
            return collection.Find(item => true).ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression) {
             return collection.Find(expression).ToList();
        }

        public T Get(string id) {
            return collection.Find(item => item.Id == id).FirstOrDefault();
        }

        public void Add(T entity) {
            collection.InsertOne(entity);
        }

        public void Update(T entity) {
            if (entity.Id == null) throw new Exception("IEntity.Id cannot be null");

            FilterDefinition<T> filterDefinition = Builders<T>.Filter.Eq(item => item.Id, entity.Id); ;
            collection.ReplaceOne(filterDefinition, entity);
        }

        public void AddMultiple(T[] entities) {
            collection.InsertMany(entities);
        }

        public void Delete(string id) {
            collection.DeleteOne(entry => entry.Id == id);
        }

        public void Delete(T entity) {
            Delete(entity.Id);
        }

        public void DeleteMultiple(T[] entities) {
            collection.DeleteMany(x => entities.Any(y => x.Id == y.Id));
        }

        public void DeleteMultiple(Expression<Func<T, bool>> expression) {
            collection.DeleteMany(expression);
        }
    }
}
