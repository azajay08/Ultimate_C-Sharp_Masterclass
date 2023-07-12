namespace GameDataParser.UserInteraction;

public class UserInterface : IUserInterface
{
	public string ReadValidFilePath()
	{
		string fileName = default;
		while (true)
		{
			Console.WriteLine("Enter the name of the file you want to read:");
			fileName = Console.ReadLine();

			if (fileName is null)
				Console.WriteLine("The file name cannot be null.");
			else if (fileName == string.Empty)
				Console.WriteLine("The file name cannot be empty.");
			else if (!File.Exists(fileName))
				Console.WriteLine("The file does not exist.");
			else
				break;
		}
		return fileName;
	}

	public void PrintMessage(string message)
	{
		Console.WriteLine(message);
	}

	public void PrintErrors(string message)
	{
		var originalColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
	}
}

