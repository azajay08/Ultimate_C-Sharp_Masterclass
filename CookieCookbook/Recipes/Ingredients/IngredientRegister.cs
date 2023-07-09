namespace CookieCookbook.Recipes.Ingredients;

public class IngredientRegister
{
	public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
	{
		new Butter(),
		new CocoaPowder(),
		new CasterSugar(),
		new BrownSugar(),
		new WheatFlour(),
		new SpeltFlour(),
		new EggYolk(),
		new EggWhite(),
		new WholeEgg(),
		new Cardomon(),
		new Cinnamon()
	};

	public Ingredient GetById(int id)
	{
		foreach (var ingredient in All)
		{
			if (ingredient.Id == id)
				return ingredient;
		}
		return null;
	}
}
