using System;

namespace Coding.Exercise
{
	public static class TupleSwapExercise
	{
		public static Tuple<T2, T1> SwapTupleItems<T1, T2>(Tuple<T1, T2> tuple)
		=> new Tuple<T2, T1>(tuple.Item2, tuple.Item1);
	}
}
