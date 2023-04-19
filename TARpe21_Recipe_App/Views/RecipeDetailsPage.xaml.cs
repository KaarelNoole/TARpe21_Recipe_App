using Models;

namespace Views;

public partial class RecipeDetailsPage : ContentPage
{
	public RecipeDetailsPage(Recipe recipe)
	{
		InitializeComponent();

		this.BindingContext = recipe;
	}

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}