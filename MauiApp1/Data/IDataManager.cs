using MauiApp1.Models;

namespace MauiApp1.Data
{
    public interface IDataManager
    {
        IList<Clovek> GetAll();
        Clovek? GetById(int? id);

        void Save(Clovek clovek);
        void Edit(Clovek clovek);
        void Delete(Clovek clovek);
    }
}
