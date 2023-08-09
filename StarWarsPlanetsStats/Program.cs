using System.Text.Json;
using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.DTOs;

try
{
	await new StarWarsPlanetsStatsApp(
		new ApiDataReader(),
		new MockStarWarsApiDataReader()).Run();
}
catch(Exception ex)
{
	Console.WriteLine("An error occured. " +
		"Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class StarWarsPlanetsStatsApp
{
	private readonly IApiDataReader _apiDataReader;
	private readonly IApiDataReader _backupApiDataReader;

	public StarWarsPlanetsStatsApp(
		IApiDataReader apiDataReader,
		IApiDataReader backupApiDataReader)
	{
		_apiDataReader = apiDataReader;
		_backupApiDataReader = backupApiDataReader;
	}

	public async Task Run()
	{
		string? json = null;

		try
		{
			IApiDataReader apiDataReader = _apiDataReader;
			json = await apiDataReader.Read(
				"https://swapi.dev/", "api/planets");
		}
		catch (HttpRequestException ex)
		{
			Console.WriteLine("API request was unsuccessful. " +
				"Switching to mock data. " +
				"Exception message: " + ex.Message);
		}
		if (json is null)
		{
			IApiDataReader apiDataReader = _backupApiDataReader;
			json = await apiDataReader.Read(
				"https://swapi.dev/", "api/planets");
		}

		var root = JsonSerializer.Deserialize<Root>(json);

		var planets = ConvertToPlanets(root);

		foreach (var p in planets)
			Console.WriteLine(p);

	}

	private IEnumerable<Planet> ConvertToPlanets(Root? root)
	{
		if (root is null)
		{
			throw new ArgumentNullException(nameof(root));
		}
		return root.results.Select(
			planetDto => (Planet)planetDto);
	}
}

