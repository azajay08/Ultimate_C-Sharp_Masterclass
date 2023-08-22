using FibonacciGenerator;
using NUnit.Framework;

namespace FibonacciGeneratorTests;

[TestFixture]
public class FibonacciTests
{
	[TestCase(47)]
	[TestCase(100)]
	[TestCase(20000000)]
	public void Genreate_ShallThrowException_IfBiggerThanMax(int input)
	{
		Assert.Throws<ArgumentException>(
			() => Fibonacci.Generate(input));
	}

	[TestCase(-47)]
	[TestCase(-1)]
	[TestCase(-20000000)]
	public void Genreate_ShallThrowException_IfLessThanZero(int input)
	{
		Assert.Throws<ArgumentException>(
			() => Fibonacci.Generate(input));
	}


	[TestCase(3, new int[] { 0, 1, 1 })]
	[TestCase(7, new int[] { 0, 1, 1, 2, 3, 5, 8 })]
	[TestCase(10, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
	public void Generate_ShallProduceValidFibonacciSequence(
		int n, int[] expected)
	{
		var result = Fibonacci.Generate(n);
		Assert.AreEqual(expected, result);
	}

	[Test]
	public void Generate_ShallProduceMaxNumberOfSequence_1134903170_When46()
	{
		var result = Fibonacci.Generate(46);
		const int FibonacciNumber46 = 1134903170;
		Assert.AreEqual(FibonacciNumber46, result.Last());
	}

	[Test]
	public void Generate_ShallBeEmpty_WhenInputIsZero()
	{
		var result = Fibonacci.Generate(0);
		Assert.IsEmpty(result);
	}

	[Test]
	public void Generate_ShallProduceSequenceOf_0_WhenInputis1()
	{
		var result = Fibonacci.Generate(1);
		Assert.AreEqual(new int[] { 0 }, result);
	}

	[Test]
	public void Generate_ShallProduceSequenceOf_0_1_WhenInputis2()
	{
		var result = Fibonacci.Generate(2);
		Assert.AreEqual(new int[] { 0, 1 }, result);
	}

}