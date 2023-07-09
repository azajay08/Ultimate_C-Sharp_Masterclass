using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes
{
	public class Recipe
	{
		public IEnumerable<Ingredient> Ingredients { get; }

		public Recipe(IEnumerable<Ingredient> ingredients)
		{
			Ingredients = ingredients;
		}

		public override string ToString()
		{
			var prepStep = new List<string>();
			foreach (var ingredient in Ingredients)
			{
				prepStep.Add($"{ingredient.Name}. {ingredient.PrepInstructions}");
			}

			return string.Join(Environment.NewLine, prepStep);
		}
	}
}

