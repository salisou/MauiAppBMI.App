using MauiAppBMI.MVVM.ViewModels;

namespace MauiAppBMI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}