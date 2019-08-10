using System;
using Enumr.Entities;

namespace Enumr
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.Write("Enter department's name: ");
			string department = Console.ReadLine();
			Console.WriteLine("Enter worker data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Level: ");
			string level = Console.ReadLine();
			Console.Write("Base salary: ");
			double baseSalary = int.Parse(Console.ReadLine());
			Console.Write("How many contracts to this worker? ");
			int contContracts = int.Parse(Console.ReadLine());
			Worker worker = new Worker(name, level, baseSalary, department);
			for (int i = 0; i < contContracts; i++)
			{
				Console.Write("Date (DD/MM/YYYY): ");
				DateTime date = DateTime.Parse(Console.ReadLine());

			}
		}
	}
}
