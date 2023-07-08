namespace CookieCookbook.Recipes.Ingredients
{
	public abstract class Egg : Ingredient
	{
		public override string PrepInstructions =>
			$"{base.PrepInstructions}";
	}
}

