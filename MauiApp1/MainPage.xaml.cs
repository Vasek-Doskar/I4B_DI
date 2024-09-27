using MauiApp1.Data;
using MauiApp1.Models;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly IDataManager _manager;
        public MainPage(IDataManager manager)
        {
            this._manager = manager;
            InitializeComponent();
            Osoby.ItemsSource = _manager.GetAll();

            Shell.Current.Navigated += (s, e) =>
            {
                Osoby.ItemsSource = null;
                Osoby.ItemsSource = _manager.GetAll();
            };
        }

        private async void Osoby_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            int hledanyID = ((Clovek)e.Item).Id;
            Clovek? hledany = _manager.GetById(hledanyID);

            string auta = "";
            hledany.Auta.ToList().ForEach(a => auta += $"{a.Znacka}, {a.Model}\n");

            await DisplayAlert($"{hledany.Jmeno}", auta, "OK");
        }
    }

}
