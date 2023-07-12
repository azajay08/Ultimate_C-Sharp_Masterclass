﻿namespace GameDataParser.UserInteraction;

public interface IUserInterface
{
	string ReadValidFilePath();
	void PrintMessage(string message);
	void PrintErrors(string message);
}

