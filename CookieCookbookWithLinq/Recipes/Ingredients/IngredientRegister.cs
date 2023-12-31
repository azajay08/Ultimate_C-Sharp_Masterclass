﻿namespace CookieCookbookWithLinq.Recipes.Ingredients;

public class IngredientRegister : IIngredientRegister
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
		new Cinnamon(),
		new Cardomon()
	};

	public Ingredient GetById(int id)
	{
		//foreach (var ingredient in All)
		//{
		//	if (ingredient.Id == id)
		//		return ingredient;
		//}
		//return null;

		var allIngredientsWithGivenId = All
			.Where(ingredient => ingredient.Id == id);

		if (allIngredientsWithGivenId.Count() > 1)
		{
			throw new InvalidOperationException(
				$"More than one ingredients has ID equal to {id}.");
		}

		return allIngredientsWithGivenId.FirstOrDefault();
	}
}
