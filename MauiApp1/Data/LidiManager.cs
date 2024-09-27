using MauiApp1.Models;

namespace MauiApp1.Data
{
    public class LidiManager : DataManager<Clovek>, ILidiManager
    {
        public LidiManager(DatabazeEF db) : base(db)
        {
        }
    }
}
