using NUnit.Framework;
using FirstUnitTesting;

namespace FirstUnitTestingTests;

[TestFixture]
//This is just to show that its a testing class

public class EnumerableExtensionsTests
{
	[Test]
	public void SumOfEvenNumbers_ShallReturnZero_EmptyCollection()
	{
		var input = Enumerable.Empty<int>();

		var result = input.SumOfEvenNumbers();

		Assert.AreEqual(0, result);
	}

	[Test]
	public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent()
	{
		var input = new int[] {1, 3, 4, 2, 4, 5};

		var result = input.SumOfEvenNumbers();

		var expected = 10;
	
		Assert.AreEqual(10, result, $"For input {string.Join(", ", input)} " +
			$"the result shall be {expected} but it was {result}");
		// The thrid argument to are equal is a message that will be triggered
		// if the test fails
	}

	[TestCase(8)]
	[TestCase(-8)]
	[TestCase(6)]
	[TestCase(0)]
	public void SumOfEvenNumbers_ShallReturnValueOfTheOnlyItem_IfItsIsEven(int number)
	{
		var input = new int[] {number};

		var result = input.SumOfEvenNumbers();

		Assert.AreEqual(number, result);
	}

	[TestCase(8, 8)]
	[TestCase(-8, -8)]
	[TestCase(6, 6)]
	[TestCase(0, 0)]
	public void SumOfEvenNumbers_ShallReturnValueOfTheOnlyItem_IfItsIsEven_TwoParams(int number, int expected)
	{
		var input = new int[] { number };

		var result = input.SumOfEvenNumbers();

		Assert.AreEqual(expected, result);
	}

	[TestCase(7, 0)]
	[TestCase(33, 0)]
	[TestCase(1, 0)]
	[TestCase(13, 0)]
	public void SumOfEvenNumbers_ShallReturnZero_IfItsIsOdd_TwoParams(int number, int expected)
	{
		var input = new int[] { number };

		var result = input.SumOfEvenNumbers();

		Assert.AreEqual(expected, result);
	}

	// Test case Source allows us to add variations of iEnumberables
	[TestCaseSource(nameof(GetSumOfEvenNumbersTestCases))]
	public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent(
		IEnumerable<int> input, int expected)
	{
		var result = input.SumOfEvenNumbers();

		var inputAsString = string.Join(", ", input);
		Assert.AreEqual(expected, result, $"For input {inputAsString} " +
			$"the result shall be {expected} but it was {result}.");
	}

	// The method must be delcared as static we return the generic <object> unless
	// we want to use the System.Collections
	private static IEnumerable<object> GetSumOfEvenNumbersTestCases()
	{
		return new[]
		{
			 new object[] { new int[] { 3, 1, 4, 6, 9 }, 10 },
			 new object[] { new List<int> { 100, 200, 1 }, 300 },
			 new object[] { new List<int> { -3, -5, 0 }, 0 },
			 new object[] { new List<int> { -4, -8 }, -12 },
		 };
	}

	[Test]
	public void SumOfEvenNumbers_ShallThrowException_ForNullInput()
	{
		IEnumerable<int>? input = null;

		var exception = Assert.Throws<ArgumentNullException>(
			() => input!.SumOfEvenNumbers());
		// The 'input' would show a warning here but we can silence it with
		// the '!' (The null forgiving operator)
	}
}

