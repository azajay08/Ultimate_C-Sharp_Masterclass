Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

String userChoice = Console.ReadLine();

Console.WriteLine("User Input: " + userChoice);

if (userChoice.ToUpper() == "S")
	PrintSelectedOption("See all TODOs");
else if (userChoice.ToUpper() == "A")
	PrintSelectedOption("Add a TODO");
else if (userChoice.ToUpper() == "R")
	PrintSelectedOption("Remove a TODO");
else if (userChoice.ToUpper() == "E")
	PrintSelectedOption("Exit");
else
	Console.WriteLine("Invalid choice!");

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

void PrintSelectedOption(String userInput)
{
	Console.WriteLine("Selected option: " + userInput);
}


//bool isUserInputAbc = userChoice == "ABC"; // same as asking if its equal to

Console.ReadKey();
