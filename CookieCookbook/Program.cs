using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;
using CookieCookbook.App;


var cookiesRecipesApp = new CookiesRecipeApp(
	new RecipeRepository(),
	new RecipeConsoleUserInteraction(new IngredientRegister()));
cookiesRecipesApp.Run("recipes.txt");

public class CookiesRecipeApp
{
	private readonly IRecipeRepository _recipeRepository;
	private readonly IRecipeConsoleUserInteraction _recipeUserInteraction;

	public CookiesRecipeApp(
		IRecipeRepository recipeRepository,
		IRecipeConsoleUserInteraction recipeUserInteraction)
	{
		_recipeRepository = recipeRepository;
		_recipeUserInteraction = recipeUserInteraction;
	}

	public void Run(string filePath)
	{
		var allRecipes = _recipeRepository.Read(filePath);
		_recipeUserInteraction.PrintExsistingRecipes(allRecipes);

		_recipeUserInteraction.PromptToCreateRecipe();

		//var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

		//if (ingredients.Count > 0)
		//{
		//	var recipe = new Recipe(ingredients);
		//	allRecipes.Add(recipe);
		//	_recipeRepository.Write(filePath, allRecipes);

		//	_recipeUserInteraction.ShowMessage("Recipe added: ");
		//	_recipeUserInteraction.ShowMessage(recipe.ToString());

		//}
		//else
		//{
		//	_recipeUserInteraction.ShowMessage(
		//		"No ingredients have been selected. " +
		//		"Recipe will not be saved.");
		//}
		_recipeUserInteraction.Exit();
	}
}
