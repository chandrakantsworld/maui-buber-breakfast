using BuberBreakfast.ViewModels;

namespace BuberBreakfast;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyBreakfastViewModel();
	}


}

