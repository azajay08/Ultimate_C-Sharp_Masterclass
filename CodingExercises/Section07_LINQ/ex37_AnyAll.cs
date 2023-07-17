using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static bool IsAnyWordWhiteSpace(List<string> words) 
		{
			return words.Any(word => word.All(chr => char.IsWhiteSpace(chr)));
		}
	}
}
