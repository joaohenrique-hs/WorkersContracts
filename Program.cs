using System;
using Enumr.Entities;
using System.Globalization;

namespace Enumr
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.Write("Enter department's name: ");
			string department = Console.ReadLine();
			Console.WriteLine("Enter worker data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Level: ");
			WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
			Console.Write("Base salary: ");
			double baseSalary = double.Parse(Console.ReadLine());
			Console.Write("How many contracts to this worker? ");
			int contContracts = int.Parse(Console.ReadLine());
			Department dept = new Department(department);
			Worker worker = new Worker(name, level, baseSalary, dept);
			DateTime date = new DateTime();
			double valuePerHour = 0;
			int Hours = 0;
			for (int i = 0; i < contContracts; i++)
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine($"Enter #{i + 1} contract data: ");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write("Date (DD/MM/YYYY): ");
				date = DateTime.Parse(Console.ReadLine());
				Console.Write("Value per hour: ");
				valuePerHour = double.Parse(Console.ReadLine());
				Console.Write("Duration (hours): ");
				Hours = int.Parse(Console.ReadLine());
				HourContract contract = new HourContract(date, valuePerHour, Hours);
				worker.addContract(contract);
			}
			Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
			string searchDate = Console.ReadLine();
			int mounth = int.Parse(searchDate.Substring(0, 2));
			int year = int.Parse(searchDate.Substring(3));
			Console.WriteLine("Name: " + worker.Name);
			Console.WriteLine("Department" + worker.Department.NameDepartment);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Income for " + searchDate + ": " + "R$" + worker.income(year, mounth).ToString("F2"));
			Console.ResetColor();
		}
	}
}
