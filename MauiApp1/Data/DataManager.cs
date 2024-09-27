using MauiApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiApp1.Data
{
    public class DataManager<TEntity> : IDataManager<TEntity> where TEntity : class
    {
        protected readonly DatabazeEF _db;
        protected readonly DbSet<TEntity> _dbSet; 

        public DataManager(DatabazeEF db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            if (entity is not null)
            {
                _dbSet.Remove(entity);
                _db.SaveChanges();
            }
        }

        public void Edit(TEntity entity)
        {
            if (entity is not null)
            {
                _dbSet.Update(entity);
                _db.SaveChanges();
            }
        }

        public IList<TEntity> GetAll() => _dbSet.ToList();

        public TEntity? GetById(int? id)
        {
            if(id is not null)
                return _dbSet.Find(id);
            return null;
        }

        public void Save(TEntity entity)
        {
            if(entity is not null)
            {
                _dbSet.Add(entity);
                _db.SaveChanges();
            }
        }
    }
}
