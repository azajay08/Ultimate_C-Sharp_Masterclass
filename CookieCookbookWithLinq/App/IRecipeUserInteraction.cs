using CookieCookbookWithLinq.Recipes;
using CookieCookbookWithLinq.Recipes.Ingredients;

namespace CookieCookbookWithLinq.App;

public interface IRecipeUserInteraction
{
	void ShowMessage(string message);
	void Exit();
	void PrintExsistingRecipes(IEnumerable<Recipe> allRecipes);
	void PromptToCreateRecipe();
	IEnumerable<Ingredient> ReadIngredientsFromUser();
}
