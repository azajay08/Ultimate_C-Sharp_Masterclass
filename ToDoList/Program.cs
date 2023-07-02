Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

String userChoice = Console.ReadLine();
Console.WriteLine("User Input: " + userChoice);
if (userChoice == "S")
    PrintSelectedOption("See all TODOs");
else if (userChoice == "A")
    PrintSelectedOption("Add a TODO");
else if (userChoice == "R")
    PrintSelectedOption("Remove a TODO");
else if (userChoice == "E")
    PrintSelectedOption("Exit");

void PrintSelectedOption(String userInput)
{
    Console.WriteLine("Selected option: " + userInput);
}


//if (userChoice.Length > 10)
//    Console.WriteLine("yeahhhhh");

//bool isUserInputAbc = userChoice == "ABC"; // same as asking if its equal to
//Console.WriteLine(isUserInputAbc);
//var number = 10;
//var isLargerThan5 = number > 5;
//Console.WriteLine(isLargerThan5);

Console.ReadKey();