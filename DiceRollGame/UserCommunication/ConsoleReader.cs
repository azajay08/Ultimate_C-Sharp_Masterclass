﻿namespace DiceRollGame.UserCommunication
{
	public static class ConsoleReader
	{
		public static int ReadIntegar(string message)
		{
			int result;
			do
			{
				Console.WriteLine(message);
			}
			while (!int.TryParse(Console.ReadLine(), out result));
			return result;
		}
	}
}