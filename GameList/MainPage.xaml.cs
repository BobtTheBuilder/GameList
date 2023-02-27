using GameList.ViewModel;

namespace GameList;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

