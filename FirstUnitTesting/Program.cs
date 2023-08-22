using FirstUnitTesting;

var input = new int[] {1, 2, 4, 6, 2, 3, 5, 1};

var result = input.SumOfEvenNumbers();
Console.WriteLine($"The sum of all even numbers in" +
	$" [{string.Join(", ", input)}] is: \n{result}");
Console.ReadKey();