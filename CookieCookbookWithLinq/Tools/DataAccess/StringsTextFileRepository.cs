﻿namespace CookieCookbookWithLinq.Tools.DataAccess;

public class StringsTextFileRepository : StringsRepository
{
	private static readonly string Separator = Environment.NewLine;

	protected override string StringsToText(List<string> strings)
	{
		return string.Join(Separator, strings);
	}

	protected override List<string> TextToStrings(string fileContents)
	{
		return fileContents.Split(Separator).ToList();
	}
}
