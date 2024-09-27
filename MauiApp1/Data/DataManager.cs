using MauiApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace MauiApp1.Data
{
    public class DataManager : IDataManager
    {
        private readonly DatabazeEF _db;

        public DataManager(DatabazeEF db)
        {
            _db = db;
        }

        public void Delete(Clovek clovek)
        {
            if (clovek is not null)
            {
                _db.Remove(clovek);
                _db.SaveChanges();
            }
        }

        public void Edit(Clovek clovek)
        {
            if (clovek is not null)
            {
                _db.Update(clovek);
                _db.SaveChanges();
            }
        }

        public IList<Clovek> GetAll() => _db.Lidi.ToList();

        public Clovek? GetById(int? id)
        {
            if(id is not null)
            {
                return _db.Lidi
                    .Include(a => a.Auta)
                    .FirstOrDefault(a => a.Id == id);
            }
            return null;
        }

        public void Save(Clovek clovek)
        {
            if(clovek is not null)
            {
                _db.Add(clovek);
                _db.SaveChanges();
            }
        }
    }
}
