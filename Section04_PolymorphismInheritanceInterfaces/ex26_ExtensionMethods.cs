using System;

namespace Coding.Exercise
{
	public static class ListExtensions
	{
		public static List<int> TakeEverySecond(this List<int> numbers)
		{
			List<int> newList = new List<int>();
			for (int i = 0; i < numbers.Count; i += 2)
				newList.Add(numbers[i]);
			return newList;
		}
	}
}
