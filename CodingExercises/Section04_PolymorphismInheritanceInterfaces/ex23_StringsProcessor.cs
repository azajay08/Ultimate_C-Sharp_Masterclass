using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public List<string> ProcessAll(List<string> words)
		{
			var stringsProcessors = new List<StringsProcessor>
				{
					new StringsTrimmingProcessor(),
					new StringsUppercaseProcessor()
				};

			List<string> result = words;
			foreach (var stringsProcessor in stringsProcessors)
			{
				result = stringsProcessor.Process(result);
			}
			return result;
		}
	}

	public class StringsProcessor
	{
		public List<string> Process(List<string> strings)
		{
			var processList = new List<string>();
			foreach (var str in strings)
			{
				processList.Add(ProcessStyle(str));
			}
			return processList;
		}
		
		protected virtual string ProcessStyle(string input) => input;
	}

	public class StringsTrimmingProcessor : StringsProcessor
	{
		protected override string ProcessStyle(string input) =>
			input.Substring(0, input.Length / 2);
	}

	public class StringsUppercaseProcessor : StringsProcessor
	{
		protected override string ProcessStyle(string input) => input.ToUpper();
	}
}
