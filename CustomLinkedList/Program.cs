using CustomLinkedList.ListUtils;

var list = new SinglyLinkedList<string>();

list.AddToFront("a");
list.AddToFront("b");
list.AddToFront("c");
int i = 1;

Console.WriteLine("Add to front.");
Console.WriteLine($"List count: {list.Count}");
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}
Console.WriteLine();
list.AddToBack("d");

Console.WriteLine("Add to end.");
Console.WriteLine($"List count: {list.Count}");
i = 1;
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}

Console.WriteLine();
list.Remove("b");
Console.WriteLine("Removing.");
Console.WriteLine($"List count: {list.Count}");
i = 1;
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}

Console.WriteLine();
Console.WriteLine("Clear.");
list.Clear();
Console.WriteLine($"List count: {list.Count}");
i = 1;
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}

Console.WriteLine();
list.Add("I'm back!");
Console.WriteLine("Cleared and adding.");
Console.WriteLine($"List count: {list.Count}");
i = 1;
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}

Console.WriteLine();
list.Remove("b");
Console.WriteLine("Removing.");
Console.WriteLine($"List count: {list.Count}");
i = 1;
foreach (var item in list)
{
	Console.WriteLine($"Node({i}): {item}");
	i++;
}
Console.ReadKey();
