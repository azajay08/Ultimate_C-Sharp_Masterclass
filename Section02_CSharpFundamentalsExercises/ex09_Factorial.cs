using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static int Factorial(int number)
		{
			var result = 1;
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}
