using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

public class RecipeConsoleUserInteraction : IRecipeConsoleUserInteraction
{
	private readonly IngredientRegister _ingredientsRegister;


	public RecipeConsoleUserInteraction(IngredientRegister ingredientRegister)
	{
		_ingredientsRegister = ingredientRegister;
	}

	public void ShowMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void Exit()
	{
		Console.WriteLine("Press any key to close.");
		Console.ReadKey();
	}

	void IRecipeConsoleUserInteraction.PrintExsistingRecipes(IEnumerable<Recipe> allRecipes)
	{
		if (allRecipes.Count() > 0)
		{
			Console.WriteLine("Existing recipes are:" + Environment.NewLine);
			var recipeNum = 1;
			foreach (var recipe in allRecipes)
			{
				Console.WriteLine($"*****{recipeNum}*****");
				Console.WriteLine(recipe + Environment.NewLine);
				recipeNum++;
			}
		}
	}

	void IRecipeConsoleUserInteraction.PromptToCreateRecipe()
	{
		Console.WriteLine("Create a new cookie recipe! " +
			"Available ingrediendts are:");

		foreach (var ingredient in _ingredientsRegister.All)
		{
			Console.WriteLine(ingredient);
		}
	}

	IEnumerable<Ingredient> IRecipeConsoleUserInteraction.ReadIngredientsFromUser()
	{
		throw new NotImplementedException();
	}
}
