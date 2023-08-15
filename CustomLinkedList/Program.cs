using CustomLinkedList.ListUtils;

var list = new SinglyLinkedList<string>();

list.AddToFront("a");
list.AddToFront("b");
list.AddToFront("c");

foreach (var item in list)
{
	Console.WriteLine(item);
}

Console.ReadKey();
