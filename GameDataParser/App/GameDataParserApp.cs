using System.Text.Json;
using GameDataParser.Model;
using GameDataParser.UserInteraction;

namespace GameDataParser.App;

public class GameDataParserApp
{
	private readonly UserInterface _userInterface;

	public GameDataParserApp(UserInterface userInterface)
	{
		_userInterface = userInterface;
	}
	public void Run()
	{
		var fileName = _userInterface.ReadValidFilePath();
		var fileContents = File.ReadAllText(fileName);

		List<VideoGame> videoGames = default;
		try
		{
			videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
		}
		catch (JsonException ex)
		{
			var orignalColour = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Json in '{fileName}' file was not in a valid format. " +
				$"{Environment.NewLine}Json body: ");
			Console.WriteLine(fileContents);
			Console.ForegroundColor = orignalColour;
			throw new JsonException($"{ex.Message} The file '{fileName}' is an invalid format.", ex);
		}

		if (videoGames.Count() > 0)
		{
			Console.WriteLine();
			Console.WriteLine("Loaded games are: ");
			foreach (var game in videoGames)
			{
				Console.WriteLine(game);
			}
		}

	}
}

