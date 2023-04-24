using RecipeApp;
using RecipeApp.Pages;

namespace View;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

	async void GetStarted_Clicked(System.Object sender, System.EventArgs e)
		=> Application.Current.MainPage = new NavigationPage(new MainPage());
}