var cookiesRecipesApp = new CookiesRecipeApp();
cookiesRecipesApp.Run();

public class CookiesRecipeApp
{
	private readonly RecipeRepository _recipeRepository;
	private readonly RecipeUserInteraction _recipeUserInteraction;

	public CookiesRecipeApp(RecipeRepository recipeRepository,
		RecipeUserInteraction recipeUserInteraction)
	{
		_recipeRepository = recipeRepository;
		_recipeUserInteraction = recipeUserInteraction;
	}

	public void Run()
	{
		var allRecipes = _recipeRepository.Read(filePath);
		_recipeUserInteraction.PrintExsistingRecipes(allRecipes);

		_recipeUserInteraction.PromptToCreateRecipe();

		var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

		if (ingredients.Count > 0)
		{
			var recipes = new CookiesRecipeApp(ingredients);
			allRecipes.Add(recipe);
			_recipeRepository.Write(filePath, allRecipes);

			_recipeUserInteraction.ShowMessage("Recipe added: ");
			_recipeUserInteraction.ShowMessage(recipes.ToString());

		}
		else
		{
			_recipeUserInteraction.ShowMessage(
				"No ingredients have been selected. " +
				"Recipe will not be saved.");
		}
		_recipeUserInteraction.Exit();
	}
}

public class RecipeUserInteraction
{
	public void ShowMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void Exit()
	{
		Console.WriteLine("Press any key to close.");
		Console.ReadKey();
	}
}

public class RecipeRepository
{
}