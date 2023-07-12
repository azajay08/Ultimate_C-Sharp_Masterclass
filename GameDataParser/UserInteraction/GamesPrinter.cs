namespace GameDataParser.UserInteraction;

using GameDataParser.Model;

public class GamesPrinter : IGamesPrinter
{
	private readonly IUserInterface _userInterface;

	public GamesPrinter(IUserInterface userInteractor)
	{
		_userInterface = userInteractor;
	}

	public void Print(List<VideoGame> videoGames)
	{
		if (videoGames.Count > 0)
		{
			_userInterface.PrintMessage(
				Environment.NewLine + "Loaded games are:");
			foreach (var videoGame in videoGames)
			{
				_userInterface.PrintMessage(videoGame.ToString());
			}
		}
		else
		{
			_userInterface.PrintMessage(
				"No games are present in the input file.");
		}
	}
}

