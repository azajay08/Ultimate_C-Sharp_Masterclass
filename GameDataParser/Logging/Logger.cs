namespace GameDataParser.Logging;

public class Logger
{
	private readonly string _logName;

	public Logger(string logName)
	{
		_logName = logName;
	}

	public void Log(Exception ex)
	{
		var logEntry = $@"[{DateTime.Now}]
Exception message: {ex.Message}
Stack trace: {ex.StackTrace}

";
		File.AppendAllText(_logName, logEntry);
	}
}
