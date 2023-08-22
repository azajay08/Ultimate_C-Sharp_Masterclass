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
}

