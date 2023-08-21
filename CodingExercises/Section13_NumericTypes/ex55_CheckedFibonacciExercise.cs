using System;

namespace Coding.Exercise
{
	public static class CheckedFibonacciExercise
	{
		public static IEnumerable<int> GetFibonacci(int n)
		{
			checked
			{
				int a = -1;
				int b = 1;
				for (int i = 0; i < n; i++)
				{
					int sum = a + b;
					yield return sum;
					a = b;
					b = sum;
				}
			}
		}
	}
}
