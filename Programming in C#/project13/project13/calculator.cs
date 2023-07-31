using System;
namespace project13
{
	public class calculator
	{
		public void cal(int a, int b, char assignment) 
		{
			switch(assignment)
			{
				case '+': Console.WriteLine($"The addition is: {a + b}");break;
				case '-':
					if (a < b)
						Console.WriteLine($"The subtarction is: {b - a}");
					else
						Console.WriteLine($"The subtraction is: {a - b}");
					break;
				case '*': Console.WriteLine($"The product is: {a * b}");break;
				case '/':
					if (a < b)
						Console.WriteLine($"The division is: {b / a}");
					else
                        Console.WriteLine($"The division is: {a / b}");
					break;
				default:Console.WriteLine("Incorrect selection");break;
            }
		}
	}
}

