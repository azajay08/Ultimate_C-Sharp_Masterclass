using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static int AbsoluteOfSum(int a, int b)
		{
			var sum = a + b;
			if (sum < 0)
				return sum *= -1;
			return sum;
		}
	}
}
