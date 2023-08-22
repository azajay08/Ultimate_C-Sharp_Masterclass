using FibonacciGenerator;

var a = Fibonacci.Generate(7);
var b = Fibonacci.Generate(10);
var c = Fibonacci.Generate(3);
var d = Fibonacci.Generate(46);

Console.WriteLine(String.Join(", ", a));
Console.WriteLine(String.Join(", ", b));
Console.WriteLine(String.Join(", ", c));
Console.WriteLine(String.Join(", ", d));