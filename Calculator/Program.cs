Console.WriteLine("Hello");
Console.WriteLine("Input the first number: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if (choice.ToUpper() == "A")
{
    var sum = first + second;
    PrintFinalEquation(first, second, sum, "+");
}
else if (choice.ToUpper() == "S")
{
    var sum = first - second;
    PrintFinalEquation(first, second, sum, "-");
}
else if (choice.ToUpper() == "M")
{
    var sum = first * second;
    PrintFinalEquation(first, second, sum, "*");
}
else
    Console.WriteLine("Invalid choice!");

void PrintFinalEquation(int first, int second, int sum, string @operator)
{
    Console.WriteLine($"{first} {@operator} {second} = {sum}");
}

Console.ReadKey();
