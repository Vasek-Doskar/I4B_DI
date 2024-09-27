using MauiApp1.Models;

namespace MauiApp1.Data
{
    public interface IDataManager<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
        TEntity? GetById(int? id);

        void Save(TEntity entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
    }
}
