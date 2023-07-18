using System;

namespace Coding.Exercise
{
	public static class RefModifierFastForwardToSummerExercise
	{
		public static void FastForwardToSummer(ref DateTime date)
		{
			var firstDayOfSummer = new DateTime(date.Year, 6, 21);
			if (date < firstDayOfSummer)
				date = firstDayOfSummer;
		}
	}
}
