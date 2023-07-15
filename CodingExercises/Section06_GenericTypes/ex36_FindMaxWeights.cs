using System;

namespace Coding.Exercise
{
	public static class Exercise
	{
		public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
		{
			var petWeights = new Dictionary<PetType, double>(); 
			
			foreach(var pet in pets)
			{
				if (!petWeights.ContainsKey(pet.PetType) ||
				pet.Weight > petWeights[pet.PetType])
				{
					petWeights[pet.PetType] = pet.Weight;
				}
			}
			return petWeights;
		}
	}

	public class Pet
	{
		public PetType PetType { get; }
		public double Weight { get; }

		public Pet(PetType petType, double weight)
		{
			PetType = petType;
			Weight = weight;    
		}
		
		public override string ToString() => $"{PetType}, {Weight} kilos";
	}

	public enum PetType { Dog, Cat, Fish }
}