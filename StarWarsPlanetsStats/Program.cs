using System.Text.Json;
using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.DTOs;

try
{
	await new StarWarsPlanetsStatsApp().Run();
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
	public async Task Run()
	{
		string json = null;

		try
		{
			IApiDataReader apiDataReader = new ApiDataReader();
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
			IApiDataReader apiDataReader = new MockStarWarsApiDataReader();
			json = await apiDataReader.Read(
				"https://swapi.dev/", "api/planets");
		}

		var root = JsonSerializer.Deserialize<Root>(json);
	}
}

