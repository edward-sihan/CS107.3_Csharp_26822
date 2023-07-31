using System;
namespace classes
{
	public class calculator
	{
		public void addition(int a,int b)
		{
			Console.WriteLine($"The addition is {a + b}");
		}
		public void subtract(int a, int b)
		{
			if (a > b)
				Console.WriteLine($"The subtraction is {a - b}");
			else
				Console.WriteLine($"The subtraction is {b - a}");
		}
		public void product(int a, int b)
		{
			Console.WriteLine($"The prosuct is {a * b}");
		}
		public void division(int a, int b)
		{
			if (a > b)
				Console.WriteLine($"The division is {a / b}");
			else
				Console.WriteLine($"The division is {b / a}");
		}


	}
}

