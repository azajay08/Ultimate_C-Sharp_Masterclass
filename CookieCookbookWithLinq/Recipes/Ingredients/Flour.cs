namespace CookieCookbookWithLinq.Recipes.Ingredients
{
	public abstract class Flour : Ingredient
	{
		public override string PrepInstructions =>
			$"Sieve. {base.PrepInstructions}";
	}
}

