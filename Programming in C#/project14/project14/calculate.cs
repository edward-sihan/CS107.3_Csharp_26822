using System;
namespace project14
{
	public class calculate
	{
		public void circle(int radius)
		{
			double area, circum;
			area = Math.PI * radius * radius;
			circum = 2 * Math.PI * radius;
			Console.WriteLine($"The area of the circle is:{area}");
			Console.WriteLine($"The circumference of the circle is: {circum}");
		}
	}
}

