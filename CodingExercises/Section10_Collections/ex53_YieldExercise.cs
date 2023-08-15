using System;

namespace Coding.Exercise
{
	public class YieldExercise
	{
		public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
		{
			for (int i = input.Count - 1; i >= 0; i--)
			{
				if (input[i] == null)
				{
					yield break;
				}
				yield return input[i];
			}
		}
	}
}
