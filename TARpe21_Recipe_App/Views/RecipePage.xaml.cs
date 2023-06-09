using TARpe21_Recipe_App.Services;

namespace Views;

public partial class RecipePage : ContentPage
{

    private const uint AnimationDuration = 800u;
    public RecipePage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		lstAllRecipe.ItemsSource = RecipeService.GetAllRecipes();
	}

	async void Recipes_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new RecipeDetailsPage(e.CurrentSelection.First() as Recipe));
	}
}
