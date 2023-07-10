using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

public class RecipeUserInteraction : IRecipeUserInteraction
{
	private readonly IIngredientRegister _ingredientsRegister;


	public RecipeUserInteraction(IIngredientRegister ingredientRegister)
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

	public void PrintExsistingRecipes(IEnumerable<Recipe> allRecipes)
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

	public void PromptToCreateRecipe()
	{
		Console.WriteLine("Create a new cookie recipe! " +
			"Available ingredients are:");

		foreach (var ingredient in _ingredientsRegister.All)
		{
			Console.WriteLine(ingredient);
		}
	}

	public IEnumerable<Ingredient> ReadIngredientsFromUser()
	{
		var ingredients = new List<Ingredient>();
		while (true)
		{
			Console.WriteLine("Add an ingredient by ID, " +
				"or type anything else.");

			var userInput = Console.ReadLine();

			if (int.TryParse(userInput, out int id))
			{
				var selectedIngredient = _ingredientsRegister.GetById(id);
				if (selectedIngredient is not null)
					ingredients.Add(selectedIngredient);
			}
			else
				break;
		}

		return ingredients;
	}
}
