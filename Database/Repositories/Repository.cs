
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using Database.Interfaces;
using Database.Models;

namespace Database.Repositories
{
    public class Repository<TEntity, TID> : IRepository<TEntity, TID> where TEntity : EntityBase
    {
        protected readonly DbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj) => DbSet.Add(obj);

        public virtual TEntity GetById(TID id) => DbSet.Find(id);

        public virtual TEntity GetById(Guid id, string includes){
            var dbSet = DbSet;

            foreach (var item in includes.Split(','))
            {
                dbSet.Include(item);
            }

            return dbSet.FirstOrDefault(o => o.Id == id);
        }

        public virtual IQueryable<TEntity> GetAll() => DbSet;

        public virtual void Update(TEntity obj) => DbSet.Update(obj);

        public virtual void Remove(TID id) => DbSet.Remove(DbSet.Find(id));

        public int SaveChanges() => Db.SaveChanges();

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
