using System;

namespace Coding.Exercise
{
	public static class NumericTypesDescriber
	{
		public static string Describe(object someObject)
		{
			if (someObject is int asInt)
				return $"Int of value {asInt}";
			if (someObject is double asDouble)
				return $"Double of value {asDouble}";
			if (someObject is decimal asDecimal)
				return $"Decimal of value {asDecimal}";
			return null;
		}
	}
}
