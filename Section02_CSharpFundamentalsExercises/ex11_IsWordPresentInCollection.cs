using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
		{
			for (int i = 0; i < words.Length; i++)
			{
				if (wordToBeChecked == words[i])
					return true;
			}
			return false;
		}
	}
}
