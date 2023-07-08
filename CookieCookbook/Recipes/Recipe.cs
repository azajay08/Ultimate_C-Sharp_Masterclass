namespace CookieCookbook.Recipes
{
	public class Recipe
	{
		public IEnumerable<Ingredient> Ingredients { get; }

		public Recipe(IEnumerable<Ingredient> ingredients)
		{
			Ingredients = ingredients;
		}
	}

	public abstract class Ingredient
	{
		public abstract int Id { get; }
		public abstract string Name { get;  }
		public virtual string PrepInstructions =>
			"Add to other ingredients";
	}

	public class Butter : Ingredient
	{
		public override int Id => 1;
		public override string Name => "Butter";
		public override string PrepInstructions =>
			$"Melt on low heat. {base.PrepInstructions}";
	}

	public class CocoaPowder : Ingredient
	{
		public override int Id => 2;
		public override string Name => "Cocoa poweder";
		public override string PrepInstructions =>
			$"Take 1/2 cup. {base.PrepInstructions}";
	}

	public abstract class Sugar : Ingredient
	{
		public override string PrepInstructions =>
			$"Take 1 cup. {base.PrepInstructions}";
	}

	public class CasterSugar : Sugar
	{
		public override int Id => 3;
		public override string Name => "Caster suagr";
	}

	public class BrownSugar : Sugar
	{
		public override int Id => 4;
		public override string Name => "Brown suagr";
	}

	public abstract class Flour : Ingredient
	{
		public override string PrepInstructions =>
			$"Sieve. {base.PrepInstructions}";
	}

	public class WheatFlour : Flour
	{
		public override int Id => 5;
		public override string Name => "Wheat flour";
	}

	public class SpeltFlour : Ingredient
	{
		public override int Id => 6;
		public override string Name => "Spelt flour";
	}

	public abstract class Egg : Ingredient
	{
		public override string PrepInstructions =>
			$"{base.PrepInstructions} Mix";
	}

	public class EggYolk : Egg
	{
		public override int Id => 7;
		public override string Name => "Egg yolk";
	}

	public class EggWhite : Egg
	{
		public override int Id => 8;
		public override string Name => "Egg white";
	}

	public class WholeEgg : Egg
	{
		public override int Id => 9;
		public override string Name => "Whole Egg";
		public override string PrepInstructions =>
			$"Beat the egg. {base.PrepInstructions}. Mix";
	}

	
}

