using CookieCookbookWithLinq.Recipes.Ingredients;
using CookieCookbookWithLinq.Tools.DataAccess;

namespace CookieCookbookWithLinq.Recipes;

public class RecipeRepository : IRecipeRepository
{
	private readonly IStringsRepository _stringsRepository;
	private readonly IIngredientRegister _ingredientRegister;
	private const string separator = ",";

	public RecipeRepository(
		IStringsRepository stringsRepository,
		IIngredientRegister ingredientRegister)
	{
		_stringsRepository = stringsRepository;
		_ingredientRegister = ingredientRegister;
	}

	public List<Recipe> Read(string filePath)
	{
		//List<string> recipesFromFile = _stringsRepository.Read(filePath);

		//var recipes = new List<Recipe>();
		//foreach (var recipeFromFile in recipesFromFile)
		//{
		//	var recipe = RecipeFromString(recipeFromFile);
		//	recipes.Add(recipe);
		//}

		//return recipes;

		return _stringsRepository.Read(filePath)
			.Select(RecipeFromString)
			.ToList();

	}

	private Recipe RecipeFromString(string recipeFromFile)
	{
		//var strIds = recipeFromFile.Split(separator);
		//var ingredients = new List<Ingredient>();

		//foreach (var recipeId in strIds)
		//{
		//	var id = int.Parse(recipeId);
		//	var ingredient = _ingredientRegister.GetById(id);
		//	ingredients.Add(ingredient);
		//}

		var ingredients = recipeFromFile.Split(separator)
			.Select(int.Parse)
			.Select(_ingredientRegister.GetById);

		return new Recipe(ingredients);

	}

	public void Write(string filePath, List<Recipe> allRecipes)
	{
		//var recipesAsStrings = new List<string>();

		//foreach (var recipe in allRecipes)
		//{
		//	var recipeIds = new List<int>();
		//	foreach (var ingredient in recipe.Ingredients)
		//	{
		//		recipeIds.Add(ingredient.Id);
		//	}
		//	recipesAsStrings.Add(string.Join(separator, recipeIds));
		//}
		//_stringsRepository.Write(filePath, recipesAsStrings);

		var recipeAsStrings = allRecipes
			.Select(recipe =>
			{
				var allIds = recipe.Ingredients
					.Select(ingredient => ingredient.Id);
				return string.Join(separator, allIds);
			});

		_stringsRepository.Write(filePath, recipeAsStrings.ToList());
	}
}