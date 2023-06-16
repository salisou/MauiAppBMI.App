using MauiAppBMI.MVVM.Views;

namespace MauiAppBMI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}
