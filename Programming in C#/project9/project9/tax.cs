using System;
namespace project9
{
	public class tax
	{
		public void calculation (int salary,int tax)
		{
			double nsalary;
			nsalary = salary - ((tax * salary) / 100);
			Console.WriteLine($"The new salary after tax is:{nsalary}");
		}
	}
}

