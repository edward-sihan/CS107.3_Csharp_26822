using System;
namespace project7
{
	public class area
	{
		public void circle(int radius)
		{
			double area;
			area = Math.PI * radius * radius;
			Console.WriteLine($"The area of the circle is: {area}");
		}
	}
}

