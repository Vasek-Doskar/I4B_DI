using MauiApp1.Data;
using MauiApp1.Models;

namespace MauiApp1.Pages;

public partial class NovyClovek : ContentPage
{
    private readonly ILidiManager _manager;
    public NovyClovek(ILidiManager manager)
	{
        _manager = manager;
		InitializeComponent();       
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string jmeno = ForName.Text;
        if(jmeno.Length > 3)
        {
            _manager.Save(new Clovek() { Jmeno = jmeno });
            await DisplayAlert("Uloženo", $"Èlovìk({jmeno}) uložen!", "ok");
            ForName.Text = string.Empty;           
        }        
    }
}