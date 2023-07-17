namespace CookieCookbookWithLinq.Tools.FileFormatting;

public class FileTypedata
{
	public string Name { get; }
	public FileFormat Format { get; }

	public FileTypedata(string name, FileFormat format)
	{
		Name = name;
		Format = format;
	}

	public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}