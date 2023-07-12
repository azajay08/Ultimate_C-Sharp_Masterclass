using System;

namespace Coding.Exercise
{
	public class Dog
	{
		private string _name;
		private string _breed;
		private int _weight;
		
		public Dog(string name, string breed, int weight)
		{
			_name = name;
			_breed = breed;
			_weight = weight;
		}
		
		public Dog(string name, int weight) : this(name, "mixed-breed", weight)
		{
		}
		
		public string Describe()
		{
			return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {GetSize()} dog.";
		}
		
		public string GetSize()
		{
			if (_weight < 5)
				return "tiny";
			if (_weight < 30)
				return "medium";
			return "large";
		}
	}
}
