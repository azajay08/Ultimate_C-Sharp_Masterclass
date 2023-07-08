namespace CookieCookbook.Recipes.Ingredients
{
	public class Butter : Ingredient
	{
		public override int Id => 1;
		public override string Name => "Butter";
		public override string PrepInstructions =>
			$"Melt on low heat. {base.PrepInstructions}";
	}
}

