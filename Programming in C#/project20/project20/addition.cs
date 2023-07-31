using System;
namespace project20
{
	public class addition
	{
		private int num1;
		private int num2;
		private int answer;
		private int answer1;

		public void setnum (int a, int b)
		{
			num1 = a;
			num2 = b;
			answer = a + b;
			answer1 = a / b;
		}

		public int getnum()
		{
			return answer;
		}

		public int getnum2()
		{
			return answer1;
		}

	}
}

