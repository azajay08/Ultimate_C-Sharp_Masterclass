using GameDataParser.Model;

namespace GameDataParser.FileTools;

public interface IJsonFormatChecker
{
	List<VideoGame> DeserializeFrom(string fileName, string fileContents);

}

