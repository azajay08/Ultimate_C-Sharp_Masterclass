using CookieCookbook.Recipes;
using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.App;

public interface IRecipeUserInteraction
{
	void ShowMessage(string message);
	void Exit();
	void PrintExsistingRecipes(IEnumerable<Recipe> allRecipes);
	void PromptToCreateRecipe();
	IEnumerable<Ingredient> ReadIngredientsFromUser();
}
