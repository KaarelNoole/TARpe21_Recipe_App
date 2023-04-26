using System.Collections.ObjectModel;

namespace Views;

public partial class RecipePage : ContentPage
{
	public RecipePage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		//lstAllRecipe.ItemsSource = RecipesService.GetAllRecipes();
	}

	//async void Recipe_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	//{
		//await Navigation.PushAsync(new RecipeDetailsPage(e CurrentSelection.First() as Recipe));
	//}

	private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
		//var recipes = new ObservableCollection<Recipe>();
	}

}