using GameDataParser.UserInteraction;
using GameDataParser.FileTools;

namespace GameDataParser.App;

public class GameDataParserApp
{
	private readonly IUserInterface _userInterface;
	private readonly IGamesPrinter _gamesPrinter;
	private readonly IJsonFormatChecker _jsonFormatChecker;

	public GameDataParserApp(
		UserInterface userInterface,
		GamesPrinter gamesPrinter,
		JsonFormatChecker jsonFormatChecker)
	{
		_userInterface = userInterface;
		_gamesPrinter = gamesPrinter;
		_jsonFormatChecker = jsonFormatChecker;
	}
	public void Run()
	{
		var fileName = _userInterface.ReadValidFilePath();
		var fileContents = File.ReadAllText(fileName);
		var videoGames = _jsonFormatChecker.DeserializeFrom(fileName, fileContents);

		_gamesPrinter.Print(videoGames);

	}
}

