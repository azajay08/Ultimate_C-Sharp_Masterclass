using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public void TestMethod()
		{
			Func<int, bool, double> someMethod1 = Method1;
			Func<DateTime> someMethod2 = Method2;
			Action<string, string> someMethod3 = Method3;
		}
		
		public double Method1(int a, bool b) => 0;
		public DateTime Method2() => default(DateTime);
		public void Method3(string a, string b) {}
	}
}
