using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

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

	public void Write(object filePath, List<Recipe> allRecipes)
	{
		throw new NotImplementedException();
	}
}