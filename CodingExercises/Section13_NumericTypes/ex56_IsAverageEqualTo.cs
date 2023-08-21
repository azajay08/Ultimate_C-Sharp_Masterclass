using System;

namespace Coding.Exercise
{
	public static class FloatingPointNumbersExercise
	{
		public static bool IsAverageEqualTo(
			this IEnumerable<double> input, double valueToBeChecked)
		{
			const double tolerance = 0.00001;
			double sum = 0.0;
			int count = 0;
			
			foreach (double num in input)
			{
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					throw new ArgumentException(
						"Input contains NaN or Infinity values.");
				}
				sum += num;
				count++;
			}
			var average = sum / count;
			return Math.Abs(average - valueToBeChecked) < tolerance;
		}
	}
}
