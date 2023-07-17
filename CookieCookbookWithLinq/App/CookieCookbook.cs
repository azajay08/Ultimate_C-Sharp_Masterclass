using CookieCookbookWithLinq.Recipes;

namespace CookieCookbookWithLinq.App;

public class CookiesRecipeApp
{
	private readonly IRecipeRepository _recipeRepository;
	private readonly IRecipeUserInteraction _recipeUserInteraction;

	public CookiesRecipeApp(
		IRecipeRepository recipeRepository,
		IRecipeUserInteraction recipeUserInteraction)
	{
		_recipeRepository = recipeRepository;
		_recipeUserInteraction = recipeUserInteraction;
	}

	public void Run(string filePath)
	{
		var allRecipes = _recipeRepository.Read(filePath);
		_recipeUserInteraction.PrintExsistingRecipes(allRecipes);
		_recipeUserInteraction.PromptToCreateRecipe();

		var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

		if (ingredients.Count() > 0)
		{
			var recipe = new Recipe(ingredients);
			allRecipes.Add(recipe);
			_recipeRepository.Write(filePath, allRecipes);

			_recipeUserInteraction.ShowMessage("Recipe added: ");
			_recipeUserInteraction.ShowMessage(recipe.ToString());

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
