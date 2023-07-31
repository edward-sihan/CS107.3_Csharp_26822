using System;
namespace task
{
	internal class student
	{
	
		
			public void MyInfo()
			{
				Console.WriteLine("Enter your name:");
				string name = Console.ReadLine();

				Console.WriteLine("Enter the degree program");
				string degree = Console.ReadLine();

				Console.WriteLine($"Welocome {name} you are following {degree}");

			}

		
	}
}

