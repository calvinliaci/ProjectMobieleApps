using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class MainPage : ContentPage
{
	
	public MainPage(MainPageViewModel vm)
	{
        InitializeComponent();

		BindingContext = vm;
    }

}