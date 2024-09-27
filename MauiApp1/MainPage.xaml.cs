using MauiApp1.Data;
using MauiApp1.Models;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly IAutoManager _autoManager;
        private readonly ILidiManager _lidiManager;
        public MainPage(IAutoManager autoManager, ILidiManager lidiManager)
        {
            _autoManager = autoManager;
            _lidiManager = lidiManager;

            InitializeComponent();
            
            Shell.Current.Navigated += (s, e) =>
            {
                Osoby.ItemsSource = null;
                Osoby.ItemsSource = _lidiManager.GetAll();
            };
        }

        private async void Osoby_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            int hledanyID = ((Clovek)e.Item).Id;
            Clovek? hledany = _lidiManager.GetById(hledanyID);

            string auta = "";
            //hledany.Auta.ToList().ForEach(a => auta += $"{a.Znacka}, {a.Model}\n");

            await DisplayAlert($"{hledany.Jmeno}", auta, "OK");
        }
    }

}
