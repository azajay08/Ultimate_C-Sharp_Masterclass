using System;
using System.Text;

namespace Coding.Exercise
{
	public static class StringBuilderExercise
	{
		public static string Reverse(string input)
		{
			var stringBuilder = new StringBuilder(input);
			int end = stringBuilder.Length - 1;
			int start = 0;
			while (start < end)
			{
				char temp = stringBuilder[start];
				stringBuilder[start] = stringBuilder[end];
				stringBuilder[end] = temp;
				end--;
				start++;
			}
			return stringBuilder.ToString();
		}
	}
}

