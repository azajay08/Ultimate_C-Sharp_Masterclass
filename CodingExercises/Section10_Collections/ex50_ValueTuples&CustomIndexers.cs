using System;

namespace Coding.Exercise
{
	public class PairOfArrays<TLeft, TRight>
	{
		private readonly TLeft[] _left;
		private readonly TRight[] _right;

		public PairOfArrays(
			TLeft[] left, TRight[] right)
		{
			_left = left;
			_right = right;
		}

		public (TLeft Left, TRight Right) this[int indexInLeft, int indexInRight]
		{
			get
			{
				return (_left[indexInLeft], _right[indexInRight]);
			}
			set
			{
				_left[indexInLeft] = value.Left;
				_right[indexInRight] = value.Right;
			}
		}
	}
}
