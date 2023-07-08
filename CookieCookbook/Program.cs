using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;


var cookiesRecipesApp = new CookiesRecipeApp(
	new RecipeRepository(),
	new RecipeConsoleUserInteraction());
cookiesRecipesApp.Run();

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

	public void Run()
	{
		var allRecipes = _recipeRepository.Read(filePath);
		_recipeUserInteraction.PrintExsistingRecipes(allRecipes);

		_recipeUserInteraction.PromptToCreateRecipe();

		var ingredients = _recipeUserInteraction.ReadIngredientsFromUser();

		if (ingredients.Count > 0)
		{
			var recipes = new Recipe(ingredients);
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

public interface IRecipeConsoleUserInteraction
{
	void ShowMessage(string message);
	void Exit();
}

public interface IRecipeRepository
{
	List<Recipe> Read(string filePath);
}

public class RecipeConsoleUserInteraction : IRecipeConsoleUserInteraction
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

public class RecipeRepository : IRecipeRepository
{
	public List<Recipe> Read(string filePath)
	{
		return new List<Recipe>
		{
			new Recipe(new List<Ingredient>
			{
				new WheatFlour(),
				new Butter(),
				new CasterSugar()
			}),
			new Recipe(new List<Ingredient>
			{
				new CocoaPowder(),
				new SpeltFlour(),
				new Cinnamon()
			})
		};

	}
}