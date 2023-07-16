IDataDownloader dataDownloader = new CachingDataDownloader(
	new PrintingDataDownloader(new SlowDataDownloader()));

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public class Cache<TKey, TData>
{
	private readonly Dictionary<TKey, TData> _cacheData = new();

	public TData Get(TKey key, Func<TKey, TData> newEntry)
	{
		if (!_cacheData.ContainsKey(key))
		{
			_cacheData[key] = newEntry(key);
		}
		return _cacheData[key];
	}
}
public class PrintingDataDownloader : IDataDownloader
{
	private readonly IDataDownloader _dataDownloader;

	public PrintingDataDownloader(IDataDownloader dataDownloader)
	{
		_dataDownloader = dataDownloader;
	}

	public string DownloadData(string resourceId)
	{
		var data = _dataDownloader.DownloadData(resourceId);
		Console.WriteLine("Data is ready!");
		return data;
	}
}

public class CachingDataDownloader : IDataDownloader
{
	private readonly IDataDownloader _dataDownloader;
	private readonly Cache<string, string> _cache = new();

	public CachingDataDownloader(IDataDownloader dataDownloader)
	{
		_dataDownloader = dataDownloader;
	}

	public string DownloadData(string resourceId)
	{
		return _cache.Get(resourceId, _dataDownloader.DownloadData);
	}
}

public interface IDataDownloader
{
	string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{

	public string DownloadData(string resourceId)
	{
		// This is a replicating the behaviour of slow downloading
		Thread.Sleep(1000);
		return $"Some data for {resourceId}";
	}
}