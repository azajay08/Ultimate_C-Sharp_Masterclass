// [assembly:InternalsVisibleTo("FirstUnitTestingTests")]
// ^^^ This can be added to test internal methods

namespace FirstUnitTesting;

public static class EnumberableExtensions
{
	public static int SumOfEvenNumbers(
		this IEnumerable<int> numbers)
	{
		int sum = 0;
		foreach (var num in  numbers)
		{
			if (num % 2 == 0)
				sum += num;
		}
		return sum;
	}
}

