using MauiApp1.Models;

namespace MauiApp1.Data
{
    public class AutoManager : DataManager<Auto>, IAutoManager
    {
        public AutoManager(DatabazeEF db) : base(db)
        {
        }
    }
}
