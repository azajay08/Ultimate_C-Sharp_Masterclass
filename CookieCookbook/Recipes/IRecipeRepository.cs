namespace CookieCookbook.Recipes;

public interface IRecipeRepository
{
	List<Recipe> Read(string filePath);
	void Write(object filePath, List<Recipe> allRecipes);
}
