using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static string RepeatCharacter(char character, int targetLength)
		{
			string str = "";
			do
			{
				str += character;
			}
			while (str.Length < targetLength);
			
			return str;
		}
	}
}