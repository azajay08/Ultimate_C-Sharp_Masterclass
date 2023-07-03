using System.Xml;

var toTOList = new List<string>();

while (true)
{
	Console.WriteLine();
	Console.WriteLine("What do you want to do?");
	Console.WriteLine("[S]ee all todos");
	Console.WriteLine("[A]dd a todo");
	Console.WriteLine("[R]emove a todo");
	Console.WriteLine("[E]xit");

	var userChoice = Console.ReadLine();

	if (userChoice.ToUpper() == "S")
		showToDo();
	else if (userChoice.ToUpper() == "A")
		addToList();
	else if (userChoice.ToUpper() == "R")
		removeToDo();
	else if (userChoice.ToUpper() == "E")
		break;
	else
		Console.WriteLine("Invalid choice!");
}

void removeToDo()
{
	if (toTOList.Count == 0)
	{
		Console.WriteLine("No TODOs have been added yet.");
		return;
	}
	int index;
	while (true)
	{
		Console.WriteLine("Select the index of the TODO you want to remove");
		showToDo();
		if (inputIsValid(out index))
		{
			removeIndex(index);
			break;
		}
	}
}

void removeIndex(int index)
{
	var toDoToBeRemoved = toTOList[index - 1];
	toTOList.Remove(toDoToBeRemoved);
	Console.WriteLine("TODO removed: " + toDoToBeRemoved);
}

bool inputIsValid(out int index)
{
	var userIndex = Console.ReadLine();
	if (userIndex == "")
	{
		index = 0;
		Console.WriteLine("Selected index cannot be empty");
		return false;
	}
	if (int.TryParse(userIndex, out index) && index >= 1 && index <= toTOList.Count)
		return true;
	Console.WriteLine("The given index is not valid.");
	return false;
}

void addToList()
{
	while (true)
	{
		Console.WriteLine("Enter the TODO description");
		var userInput = Console.ReadLine();

		if (toTOList.Contains(userInput))
			Console.WriteLine("The description must be unique.");
		else if (userInput == "")
			Console.WriteLine("The description cannot be empty.");
		else
		{
			toTOList.Add(userInput);
			break;
		}

	}
}

void showToDo()
{
	if (toTOList.Count == 0)
	{
		Console.WriteLine("No TODOs have been added yet.");
		return;
	}
	for (int i = 0; i < toTOList.Count; i++)
	{
		Console.WriteLine($"{i + 1}. {toTOList[i]}");
	}
}


//Console.ReadKey();

//switch(userChoice)
//{
//	case "S":
//	case "s":
//		PrintSelectedOption("See all TODOs");
//		break;
//	case "A":
//	case "a":
//		PrintSelectedOption("Add a TODO");
//		break;
//	case "R":
//	case "r":
//		PrintSelectedOption("Remove a TODO");
//		break;
//	case "E":
//	case "e":
//		PrintSelectedOption("Exit");
//		break;
//	default:
//		Console.WriteLine("Invalid choice!");
//		break;
//}