namespace CookieCookbookWithLinq.Recipes.Ingredients
{
	public class CocoaPowder : Ingredient
	{
		public override int Id => 2;
		public override string Name => "Cocoa poweder";
		public override string PrepInstructions =>
			$"Take 1/2 cup. {base.PrepInstructions}";
	}
}

