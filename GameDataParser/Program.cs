using GameDataParser.App;
using GameDataParser.UserInteraction;
using GameDataParser.Logging;
using GameDataParser.FileTools;

var userInterface = new UserInterface();

var app = new GameDataParserApp(
	userInterface,
	new GamesPrinter(userInterface),
	new JsonFormatChecker(userInterface));
var logger = new Logger("log.txt");

try
{
	app.Run();
}
catch (Exception ex)
{
	Console.WriteLine("Sorry! The application has experienced an " +
		"unexpected error and will have to be closed.");
	logger.Log(ex);
}

Console.WriteLine("Press any key to close.");

Console.ReadKey();
