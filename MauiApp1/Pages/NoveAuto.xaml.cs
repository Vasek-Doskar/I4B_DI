using MauiApp1.Data;
using MauiApp1.Models;
using System.Collections;
namespace MauiApp1.Pages;

public partial class NoveAuto : ContentPage
{
	private readonly IDataManager _manager;
	public NoveAuto(IDataManager manager)
	{
        _manager = manager;

        InitializeComponent();
		ForFuel.ItemsSource = Enum.GetValues(typeof(Palivo)).Cast<Palivo>() as IList;

        Shell.Current.Navigated += (s, e) =>
        {
            ForOwner.ItemsSource = null;
            ForOwner.ItemsSource = _manager.GetAll() as IList;
        };

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}