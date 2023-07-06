using System;

namespace Coding.Exercise
{
	public static class NumberToDayOfWeekTranslator
	{
		public static string Translate(int number)
		{
			if (number == 1)
				return "Monday";
			if (number == 2)
				return "Tuesday";
			if (number == 3)
				return "Wednesday";
			if (number == 4)
				return "Thursday";
			if (number == 5)
				return "Friday";
			if (number == 6)
				return "Saturday";
			if (number == 7)
				return "Sunday";
			return "Invalid day of the week";
		}
	}
}
