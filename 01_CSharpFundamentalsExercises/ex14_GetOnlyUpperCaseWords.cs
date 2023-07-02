using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public List<string> GetOnlyUpperCaseWords(List<string> words)
		{
			var capitalList = new List<string>();
			foreach (var word in words)
			{
				if (capitalList.Contains(word))
					continue;
				if (IsUpperCase(word))
					capitalList.Add(word);
			}
			return capitalList;
		}
		
		bool IsUpperCase(string word)
		{
			foreach (char letter in word)
			{
				if (!char.IsUpper(letter))
					return false;
			}
			return true;
		}
	}
}
