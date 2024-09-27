using MauiApp1.Data;
using MauiApp1.Models;

namespace MauiApp1.Pages;

public partial class NovyClovek : ContentPage
{
    private readonly DatabazeEF Db;
    public NovyClovek(DatabazeEF db)
	{
        Db = db;
		InitializeComponent();
       
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string jmeno = ForName.Text;
        if(jmeno.Length > 3)
        {
            Db.Lidi.Add(new Clovek() { Jmeno = jmeno });
            Db.SaveChanges();
            await DisplayAlert("Uloženo", $"Èlovìk({jmeno}) uložen!", "ok");
            ForName.Text = string.Empty;           
        }        
    }
}