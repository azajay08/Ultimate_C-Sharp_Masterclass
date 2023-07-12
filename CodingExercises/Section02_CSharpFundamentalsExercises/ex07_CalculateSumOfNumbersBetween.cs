using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
		{
			var sum = 0;
			while (firstNumber <= lastNumber)
			{
				sum += firstNumber;
				firstNumber++;
			}
			return sum;
		}
	}
}