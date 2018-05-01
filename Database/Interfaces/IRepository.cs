using System;
using System.Linq;
using System.Linq.Expressions;
using Database.Models;

namespace Database.Interfaces
{
    public interface IRepository<TEntity, in TID> : IDisposable where TEntity : EntityBase
    {
        void Add(TEntity entity);

        TEntity GetById(TID id);

        TEntity GetById(Guid id, string includes);

        IQueryable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TID id);

        int SaveChanges();
    }
}
