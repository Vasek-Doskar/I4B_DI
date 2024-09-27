using MauiApp1.Data;
using MauiApp1.Models;
using System.Collections;
namespace MauiApp1.Pages;

public partial class NoveAuto : ContentPage
{
	private readonly IAutoManager _autoManager;
	private readonly ILidiManager _lidiManager;
	public NoveAuto(IAutoManager manager, ILidiManager manager2)
	{
        _autoManager = manager;
        _lidiManager = manager2;

        InitializeComponent();
		ForFuel.ItemsSource = Enum.GetValues(typeof(Palivo)).Cast<Palivo>() as IList;

        Shell.Current.Navigated += (s, e) =>
        {
            ForOwner.ItemsSource = null;
            ForOwner.ItemsSource = _lidiManager.GetAll() as IList;
        };

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}