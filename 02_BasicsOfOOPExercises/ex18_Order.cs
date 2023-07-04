using System;

namespace Coding.Exercise
{
	public class Order
	{
		public string Item { get; }
		private DateTime _date;
		
		public DateTime Date
		{
			get { return _date; }
			set
			{
				if (DateTime.Now.Year == value.Year)
					_date = value;
			}
		}
		
		public Order(string item, DateTime date)
		{
			Item = item;
			Date = date;
		}
	}
}
