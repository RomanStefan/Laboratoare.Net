using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(int id);

        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
