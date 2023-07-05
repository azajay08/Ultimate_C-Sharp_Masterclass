using System;

namespace Coding.Exercise
{
	public static class StringsTransformator
	{
		public static string TransformSeparators(
			string input,
			string originalSeparator,
			string targetSeparator)
		{
			string[] parts = input.Split(originalSeparator);
			return string.Join(targetSeparator, parts);
		}
	}
}
