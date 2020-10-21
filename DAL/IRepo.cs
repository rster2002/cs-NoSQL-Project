using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL {
    public interface IRepo<T> where T : IEntity {
        // Create
        void Add(T entity);
        void AddMultiple(T[] entities);

        // Read
        IEnumerable<T> GetAll();
        T Get(string id);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        long Count(Expression<Func<T, bool>> expression);

        // Update
        void Update(T entity);

        // Delete
        void Delete(string id);
        void Delete(T entity);
        void DeleteMultiple(Expression<Func<T, bool>> expression);
        void DeleteMultiple(T[] entities);
    }
}
