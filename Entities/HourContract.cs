using System;

namespace Enumr.Entities
{
	class HourContract
	{
		public DateTime Date { get; private set; }
		public double ValuePerHour { get; private set; }
		public int Hours { get; set; }
		public HourContract(DateTime date, double valuePerHour, int hours)
		{
			this.Date = date;
			this.ValuePerHour = valuePerHour;
			this.Hours = hours;
		}
		public double totalValue()
		{
			double result = ValuePerHour * Hours;
			return result;
		}
	}
}