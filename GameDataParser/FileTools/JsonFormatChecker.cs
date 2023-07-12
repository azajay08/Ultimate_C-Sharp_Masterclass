using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.FileTools;

public class JsonFormatChecker : IJsonFormatChecker
{
	private readonly IUserInterface _userInterface;

	public JsonFormatChecker(IUserInterface userInterface)
	{
		_userInterface = userInterface;
	}

	public List<VideoGame> DeserializeFrom(
		string fileName, string fileContents)
	{
		try
		{
			return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
		}
		catch (JsonException ex)
		{
			_userInterface.PrintErrors($"JSON in '{fileName}' file was not " +
				$"in a valid format. {Environment.NewLine}JSON body:");
			_userInterface.PrintErrors(fileContents);

			throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
		}
	}
}

