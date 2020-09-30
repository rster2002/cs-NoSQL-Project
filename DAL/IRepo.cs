using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public interface IRepo<T> where T : IEntity {
        // Create
        void Add(T entity);
        void AddMultiple(T[] entities);

        // Read
        IEnumerable<T> GetAll();
        T Get(string id);
        IEnumerable<T> Get(FilterDefinition<T> filter);

        // Update
        void Update(T entity);

        // Delete
        void Delete(string id);
        void Delete(T entity);
        void Delete(Func<T, bool> func);
    }
}
