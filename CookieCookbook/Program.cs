using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;


var cookiesRecipesApp = new CookiesRecipeApp(
	new RecipeRepository(),
	new RecipeConsoleUserInteraction());
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

		//_recipeUserInteraction.PromptToCreateRecipe();

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

public interface IRecipeConsoleUserInteraction
{
	void ShowMessage(string message);
	void Exit();
	void PrintExsistingRecipes(IEnumerable<Recipe> allRecipes);
	void PromptToCreateRecipe();
	IEnumerable<Ingredient> ReadIngredientsFromUser();
}

public interface IRecipeRepository
{
	List<Recipe> Read(string filePath);
	void Write(object filePath, List<Recipe> allRecipes);
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
		throw new NotImplementedException();
	}

	IEnumerable<Ingredient> IRecipeConsoleUserInteraction.ReadIngredientsFromUser()
	{
		throw new NotImplementedException();
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

	void IRecipeRepository.Write(object filePath, List<Recipe> allRecipes)
	{
		throw new NotImplementedException();
	}
}