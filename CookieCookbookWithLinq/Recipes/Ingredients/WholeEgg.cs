namespace CookieCookbookWithLinq.Recipes.Ingredients
{
	public class WholeEgg : Egg
	{
		public override int Id => 9;
		public override string Name => "Whole Egg";
		public override string PrepInstructions =>
			$"Beaten. {base.PrepInstructions}";
	}
}

