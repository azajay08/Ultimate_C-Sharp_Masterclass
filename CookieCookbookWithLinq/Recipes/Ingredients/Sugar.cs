namespace CookieCookbookWithLinq.Recipes.Ingredients
{
	public abstract class Sugar : Ingredient
	{
		public override string PrepInstructions =>
			$"Take 1 cup. {base.PrepInstructions}";
	}
}

