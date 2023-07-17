namespace CookieCookbookWithLinq.Recipes.Ingredients
{
	public abstract class Spice : Ingredient
	{
		public override string PrepInstructions =>
			$"Take half a teaspoon. {base.PrepInstructions}";
	}
}

