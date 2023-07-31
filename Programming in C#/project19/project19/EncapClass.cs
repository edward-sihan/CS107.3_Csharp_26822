using System;
namespace project19
{
	public class EncapClass
	{
		private int age;
		private string name;

		public void setage(int agefromuser) //here we are assigning a value to the private variable
		{
			age = agefromuser;
		}

		public int getage() //here we are returning the private variable
		{
			return age;
		}

		public void setname(string namea)
		{
			name = namea;
		}

		public string getname()
		{
			return name;
		}
	}
}

