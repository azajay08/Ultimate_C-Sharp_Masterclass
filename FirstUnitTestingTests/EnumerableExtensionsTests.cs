using NUnit.Framework;
using FirstUnitTesting;

namespace FirstUnitTestingTests;

[TestFixture]
//This is just to show that its a testing class

public class EnumerableExtensionsTests
{
	[Test]
	public void SumOfEvenNumbers_ShouldReturnZero_EmptyCollection()
	{
		var input = Enumerable.Empty<int>();

		var result = input.SumOfEvenNumbers();

		Assert.AreEqual(0, result);
	}

	[Test]
	public void SumOfEvenNumbers_ShouldReturnNonZeroResult_IfEvenNumbersArePresent()
	{
		var input = new int[] {1, 3, 4, 2, 4, 5};

		var result = input.SumOfEvenNumbers();

		var expected = 10;
	
		Assert.AreEqual(10, result, $"For input {string.Join(", ", input)} " +
			$"the result shall be {expected} but it was {result}");
		// The thrid argument to are equal is a message that will be triggered
		// if the test fails
	}
}

