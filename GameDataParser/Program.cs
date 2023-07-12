using System.Text.Json;

var hello = "Hello";
Console.WriteLine("Enter the name of the file you want read:");

var fileName = Console.ReadLine();

var fileContents = File.ReadAllText(fileName);

var videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);

if (videoGames.Count() > 0)
{
	Console.WriteLine();
	Console.WriteLine("Loaded games are: ");
	foreach (var game in videoGames)
	{
		Console.WriteLine(game);
	}
}
Console.WriteLine("Press any key to close.");

Console.ReadKey();


public class VideoGame
{
	public string Title { get; init; }
	public int ReleaseDate { get; init; }
	public decimal Rating { get; init; }

	public override string ToString() => $"{Title} was released in {ReleaseDate}, with a rating of {Rating}";

}
