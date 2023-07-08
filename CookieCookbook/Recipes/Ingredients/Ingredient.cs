namespace CookieCookbook.Recipes.Ingredients
{
	public abstract class Ingredient
	{
		public abstract int Id { get; }
		public abstract string Name { get;  }
		public virtual string PrepInstructions =>
			"Add to other ingredients";
	}
}

