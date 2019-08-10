using System;
using System.Collections.Generic;

namespace Enumr.Entities
{
	class Worker
	{
		public string Name { get; set; }
		public WorkerLevel Level { get; set; }
		public double BaseSalary { get; set; }
		public Department Department { get; private set; }
		public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

		public Worker(string name, WorkerLevel level, double baseSalary, Department department)
		{
			Name = name;
			Level = level;
			BaseSalary = baseSalary;
			Department = department;
		}
		public Worker(string name, string level, double baseSalary, string department)
		{
			Name = name;
			Level = Enum.Parse<WorkerLevel>(level);

			BaseSalary = baseSalary;
			Department.NameDepartment = department;
		}

		public void addContract(HourContract contract)
		{
			Contracts.Add(contract);
		}
		public void removeContract(HourContract contract)
		{
			Contracts.Remove(contract);
		}
		public double income(int year, int mounth)
		{
			double sum = BaseSalary;
			foreach (HourContract c in Contracts)
			{
				if (year == c.Date.Year && mounth == c.Date.Month)
				{
					sum += c.totalValue();
				}
			}
			return sum;
		}
	}
}